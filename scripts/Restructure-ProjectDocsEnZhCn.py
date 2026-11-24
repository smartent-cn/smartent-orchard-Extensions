#!/usr/bin/env python3
"""Move project docs to docs/en and docs/zh-cn; refresh all via Ensure-ProjectDocsFolders."""

from __future__ import annotations

import shutil
import subprocess
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SRC = ROOT / "src"

# Keep in sync with scripts/Thicken-ModuleReadmes.py MODULE_FAMILIES_ORDER
MODULE_FAMILY_DIRS: tuple[str, ...] = (
    "Smartent.Orchard.AuditTrail",
    "Smartent.Orchard.ChartJs",
    "Smartent.Orchard.ContentEditors",
    "Smartent.Orchard.DataTables",
    "Smartent.Orchard.EmailClient",
    "Smartent.Orchard.Extensions.Cms",
    "Smartent.Orchard.Hosting.ApplicationInsights",
    "Smartent.Orchard.Hosting.BuildVersion",
    "Smartent.Orchard.Hosting.Tenants",
    "Smartent.Orchard.JsonEditor",
    "Smartent.Orchard.LoginAsAnybody",
    "Smartent.Orchard.Marketing",
    "Smartent.Orchard.Privacy",
    "Smartent.Orchard.TrainingDemo",
    "Smartent.Orchard.UIKit",
    "Smartent.Orchard.VueJs",
    "Smartent.Orchard.Walkthroughs",
)

TOPIC_BASES = ("QuickStart", "Usage", "Configuration", "Cautions")
LEGACY_CN_SUFFIX = "-CN.md"


def project_docs_dir(project_dir: Path) -> Path | None:
    for name in ("docs", "Docs"):
        d = project_dir / name
        if d.is_dir():
            return d
    return None


def normalize_docs_case(project_dir: Path) -> Path:
    docs = project_dir / "docs"
    legacy = project_dir / "Docs"
    if legacy.is_dir() and docs.is_dir() and legacy.resolve() == docs.resolve():
        docs.mkdir(exist_ok=True)
        return docs
    if legacy.is_dir() and not docs.is_dir():
        legacy.rename(docs)
    elif legacy.is_dir() and docs.is_dir():
        for item in legacy.iterdir():
            dest = docs / item.name
            if item.is_file():
                if not dest.exists():
                    shutil.move(str(item), str(dest))
                continue
            if not item.is_dir():
                continue
            if item.name in ("en", "zh-cn"):
                for f in item.rglob("*"):
                    if f.is_file():
                        rel = f.relative_to(item)
                        target = docs / item.name / rel
                        target.parent.mkdir(parents=True, exist_ok=True)
                        if not target.exists():
                            shutil.move(str(f), str(target))
                continue
            if not dest.exists():
                shutil.move(str(item), str(dest))
                continue
            for f in item.rglob("*"):
                if f.is_file():
                    rel = f.relative_to(item)
                    target = dest / rel
                    target.parent.mkdir(parents=True, exist_ok=True)
                    if not target.exists():
                        shutil.move(str(f), str(target))
        shutil.rmtree(legacy, ignore_errors=True)
    docs.mkdir(exist_ok=True)
    return docs


def migrate_mixed_layout(docs: Path) -> None:
    en = docs / "en"
    zh = docs / "zh-cn"
    en.mkdir(exist_ok=True)
    zh.mkdir(exist_ok=True)

    for path in list(docs.iterdir()):
        if path.is_dir() and path.name in ("en", "zh-cn", "Attachments"):
            continue
        if not path.is_file():
            continue
        name = path.name
        if name.endswith(LEGACY_CN_SUFFIX):
            target = zh / f"{name[: -len(LEGACY_CN_SUFFIX)]}.md"
            if not target.exists() or path.stat().st_mtime > target.stat().st_mtime:
                shutil.copy2(path, target)
            path.unlink(missing_ok=True)
            continue
        if name in ("README.md", "Readme-CN.md"):
            continue
        for base in TOPIC_BASES:
            if name == f"{base}.md":
                target = en / name
                if not target.exists() or path.stat().st_mtime > target.stat().st_mtime:
                    shutil.copy2(path, target)
                path.unlink(missing_ok=True)
                break


def find_project_dirs() -> list[Path]:
    dirs: set[Path] = set()
    for csproj in SRC.rglob("*.csproj"):
        if "obj" in csproj.parts or "bin" in csproj.parts:
            continue
        rel = csproj.relative_to(SRC).as_posix()
        if rel.startswith("Test/"):
            continue
        stem = csproj.stem
        if ".Tests" in stem or stem.endswith(".Tester") or "Benchmark" in stem:
            continue
        dirs.add(csproj.parent.resolve())
    for name in MODULE_FAMILY_DIRS:
        family = (SRC / "Modules" / name).resolve()
        if family.is_dir() and (family / "Readme.md").is_file():
            dirs.add(family)
    return sorted(dirs)


def restructure_repo_docs() -> None:
    pairs = [
        (ROOT / "docs" / "src-projects", "README.md", "Readme-CN.md"),
        (ROOT / "docs" / "modules", "README.md", "Readme-CN.md"),
    ]
    tpl_en = (ROOT / "docs" / "templates" / "PROJECT_DOCS_GATEWAY.en.template.md").read_text(encoding="utf-8")
    tpl_cn = (ROOT / "docs" / "templates" / "PROJECT_DOCS_GATEWAY.cn.template.md").read_text(encoding="utf-8")
    for base, en_name, cn_name in pairs:
        if not (base / en_name).is_file():
            continue
        en_body = (base / en_name).read_text(encoding="utf-8")
        cn_body = (base / cn_name).read_text(encoding="utf-8") if (base / cn_name).is_file() else ""
        en_dir = base / "en"
        zh_dir = base / "zh-cn"
        en_dir.mkdir(exist_ok=True)
        zh_dir.mkdir(exist_ok=True)
        (en_dir / "README.md").write_text(en_body, encoding="utf-8", newline="\n")
        if cn_body:
            (zh_dir / "README.md").write_text(cn_body, encoding="utf-8", newline="\n")
        title = base.name
        (base / "README.md").write_text(
            tpl_en.replace("{PackageId}", f"docs/{title}"),
            encoding="utf-8",
            newline="\n",
        )
        (base / "Readme-CN.md").write_text(
            tpl_cn.replace("{PackageId}", f"docs/{title}"),
            encoding="utf-8",
            newline="\n",
        )


def main() -> None:
    count = 0
    for project_dir in find_project_dirs():
        docs = project_docs_dir(project_dir)
        if docs is None and not (project_dir / "Readme.md").is_file():
            continue
        docs = normalize_docs_case(project_dir)
        migrate_mixed_layout(docs)
        count += 1
    restructure_repo_docs()
    script = ROOT / "scripts" / "Ensure-ProjectDocsFolders.py"
    subprocess.check_call([sys.executable, str(script)], cwd=ROOT)
    print(f"Restructured docs/en + docs/zh-cn for {count} project directories; refreshed indexes.")


if __name__ == "__main__":
    main()