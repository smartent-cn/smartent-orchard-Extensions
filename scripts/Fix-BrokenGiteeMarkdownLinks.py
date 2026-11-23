#!/usr/bin/env python3
"""Repair markdown links broken by replacing Lombiq GitHub URLs with a bare Gitee root."""

from __future__ import annotations

import os
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
MONOREPO = "https://gitee.com/smartent/smartent-orchard-Extensions"
BROKEN_MARKDOWN = "(https://gitee.com/smartent/smartent-training-demo-modules "
FIXED_MARKDOWN = f"({MONOREPO}) "
BROKEN_BARE = "https://gitee.com/smartent/smartent-training-demo-modules "
FIXED_BARE = f"{MONOREPO} "

SCOPE = ("src", "tools", "Readme.md", "scripts")


def iter_files() -> list[Path]:
    paths: list[Path] = []
    for part in SCOPE:
        p = ROOT / part
        if p.is_file():
            paths.append(p)
            continue
        if not p.is_dir():
            continue
        for root, dirs, files in os.walk(p):
            dirs[:] = [d for d in dirs if d not in {".git", "node_modules", "bin", "obj"}]
            for name in files:
                if name.endswith((
                    ".md", ".cs", ".csproj", ".yml", ".yaml", ".cshtml", ".json", ".targets", ".ps1", ".mjs",
                )):
                    paths.append(Path(root) / name)
    return paths


def main() -> None:
    changed = 0
    for path in iter_files():
        try:
            text = path.read_text(encoding="utf-8")
        except (UnicodeDecodeError, OSError):
            continue
        updated = text
        if BROKEN_MARKDOWN in updated:
            updated = updated.replace(BROKEN_MARKDOWN, FIXED_MARKDOWN)
        if BROKEN_BARE in updated:
            updated = updated.replace(BROKEN_BARE, FIXED_BARE)
        if updated == text:
            continue
        path.write_text(updated, encoding="utf-8", newline="\n")
        changed += 1
    print(f"Fixed broken Gitee markdown links in {changed} files.")


if __name__ == "__main__":
    main()