#!/usr/bin/env python3
"""Close broken markdown links after monorepo URL replacement (missing ')' before suffix text)."""

from __future__ import annotations

import os
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
GITEE = "https://gitee.com/smartent/smartent-orchard-Extensions"
GITHUB = "https://github.com/smartent-cn/smartent-orchard-Extensions"
SCOPE_DIRS = ("src", "tools", "scripts", "NuGetVerify", "docs")
ROOT_FILES = ("Readme.md",)
SKIP_DIR_NAMES = {"node_modules", "bin", "obj", ".git"}
EXT = {".md", ".cs", ".yml", ".yaml", ".csproj", ".props", ".targets", ".ps1", ".json5"}


def fix_text(text: str) -> str:
    for url in (GITEE, GITHUB):
        text = re.sub(
            rf"\({re.escape(url)}\s*$",
            f"({url})",
            text,
            flags=re.MULTILINE,
        )
        text = re.sub(
            rf"\({re.escape(url)}(\s+)(?=[A-Za-z\[#])",
            rf"({url})\1",
            text,
        )
    return text


def main() -> None:
    changed = 0
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
            for name in files:
                if Path(name).suffix.lower() not in EXT:
                    continue
                paths.append(Path(root) / name)
    for path in paths:
        try:
            text = path.read_text(encoding="utf-8")
        except (UnicodeDecodeError, OSError):
            continue
        updated = fix_text(text)
        if updated != text:
            path.write_text(updated, encoding="utf-8", newline="\n")
            changed += 1
    print(f"Fixed unclosed monorepo links in {changed} files.")


if __name__ == "__main__":
    main()