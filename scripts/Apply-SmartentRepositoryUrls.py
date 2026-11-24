#!/usr/bin/env python3
"""Point monorepo metadata URLs at smartent-orchard-Extensions (Gitee + GitHub)."""

from __future__ import annotations

import os
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SCOPE_DIRS = ("src", "tools", "scripts", "NuGetVerify", "docs", ".github")
ROOT_FILES = ("Readme.md", "Directory.Build.props", "Directory.Build.targets", "AGENTS.md")
SKIP_DIR_NAMES = {"node_modules", "bin", "obj", ".git", ".vs"}
SKIP_REL_PREFIXES = ("重构-重组-改名项目方案", os.path.join("docs", "migration"))
SKIP_BASENAMES = {"Apply-SmartentRepositoryUrls.py"}

TEXT_EXTENSIONS = {
    ".cs", ".cshtml", ".csproj", ".props", ".targets", ".md", ".json", ".json5", ".yml", ".yaml",
    ".js", ".mjs", ".ps1", ".nuspec", ".sln", ".slnx", ".liquid", ".xml", ".config", ".editorconfig",
    ".gitattributes", ".gitignore", ".html", ".txt", ".scss", ".css",
}

# Longer / more specific patterns first.
REPLACEMENTS = [
    ("https://gitee.com/smartent/smartent-training-demo-modules", "https://gitee.com/smartent/smartent-orchard-Extensions"),
    ("http://gitee.com/smartent/smartent-training-demo-modules", "https://gitee.com/smartent/smartent-orchard-Extensions"),
    ("https://github.com/smartent-cn/smartent-training-demo-modules", "https://github.com/smartent-cn/smartent-orchard-Extensions"),
    ("https://github.com/Lombiq/Open-Source-Orchard-Core-Extensions", "https://github.com/smartent-cn/smartent-orchard-Extensions"),
    ("github.com/Lombiq/Open-Source-Orchard-Core-Extensions", "github.com/smartent-cn/smartent-orchard-Extensions"),
    ("Lombiq/Open-Source-Orchard-Core-Extensions", "smartent-cn/smartent-orchard-Extensions"),
]


def should_skip(rel: str, name: str) -> bool:
    if name in SKIP_BASENAMES:
        return True
    rel_posix = rel.replace("\\", "/")
    for prefix in SKIP_REL_PREFIXES:
        if rel_posix.startswith(prefix.replace("\\", "/")):
            return True
    return False


def iter_files() -> list[Path]:
    paths: list[Path] = []
    for name in ROOT_FILES:
        p = ROOT / name
        if p.is_file():
            paths.append(p)
    for scope in SCOPE_DIRS:
        base = ROOT / scope
        if not base.is_dir():
            continue
        for root, dirs, files in os.walk(base):
            dirs[:] = [d for d in dirs if d not in SKIP_DIR_NAMES]
            for f in files:
                path = Path(root) / f
                rel = path.relative_to(ROOT).as_posix()
                if should_skip(rel, f):
                    continue
                if path.suffix.lower() not in TEXT_EXTENSIONS and f not in {"License.md", "NuGet.config"}:
                    continue
                if path.suffix.lower() in {".png", ".jpg", ".exe", ".dll", ".zip"}:
                    continue
                paths.append(path)
    return paths


def main() -> None:
    changed = 0
    for path in iter_files():
        try:
            text = path.read_text(encoding="utf-8")
        except (UnicodeDecodeError, OSError):
            continue
        updated = text
        for old, new in REPLACEMENTS:
            updated = updated.replace(old, new)
        if updated != text:
            path.write_text(updated, encoding="utf-8", newline="\n")
            changed += 1
    print(f"Repository URL update: {changed} files.")


if __name__ == "__main__":
    main()