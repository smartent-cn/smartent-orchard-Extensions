#!/usr/bin/env python3
"""Create docs/ + Docs-Index for every non-test project under src/."""

from __future__ import annotations

import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SRC = ROOT / "src"
REPO_INDEX_EN = ROOT / "docs" / "src-projects" / "README.md"
REPO_INDEX_CN = ROOT / "docs" / "src-projects" / "Readme-CN.md"
TPL = ROOT / "docs" / "templates"

AREA_ORDER = ("Build", "Demo", "Libraries", "Modules", "Platform", "Themes")


def load(name: str) -> str:
    return (TPL / name).read_text(encoding="utf-8")


def is_test_project(csproj: Path) -> bool:
    rel = csproj.relative_to(SRC).as_posix().replace("\\", "/")
    if rel.startswith("Test/"):
        return True
    stem = csproj.stem
    if stem.startswith("Smartent.Test."):
        return True
    markers = (".Tests.UI", ".Tests.Theme", ".Tests", "Tests.UI", ".Tester", "Benchmark")
    if any(m in stem for m in markers):
        return True
    for part in csproj.parts:
        if part.endswith(".Tests.UI") or part == "Tests" or part.startswith("Smartent.Test."):
            return True
    return False


def collect_projects() -> list[Path]:
    projects: list[Path] = []
    for csproj in sorted(SRC.rglob("*.csproj")):
        if "obj" in csproj.parts or "bin" in csproj.parts:
            continue
        if is_test_project(csproj):
            continue
        projects.append(csproj)
    return projects


def rel_to_repo_index(project_dir: Path) -> tuple[str, str]:
    depth = len(project_dir.relative_to(ROOT).parts)
    prefix = "/".join([".."] * depth)
    return f"{prefix}/docs/src-projects/README.md", f"{prefix}/docs/src-projects/Readme-CN.md"


def extract_section(md: str, heading: str) -> str:
    lines = md.splitlines()
    out: list[str] = []
    capture = False
    for line in lines:
        if line.startswith("## ") and capture:
            break
        if line.startswith("## ") and heading.lower() in line.lower():
            capture = True
            continue
        if capture:
            out.append(line)
    return "\n".join(out).strip()


def extract_flex(md: str, headings: list[str]) -> str:
    for h in headings:
        text = extract_section(md, h)
        if text:
            return text
    return ""


def topic_stub_en(title: str, body_en: str) -> str:
    body = body_en or "See [../Readme.md](../../Readme.md)."
    return f"# {title}\n\n> Index: [README.md](README.md) · Gateway: [../README.md](../README.md)\n\n{body}\n"


def topic_stub_cn(title: str, body_cn: str) -> str:
    body = body_cn or "见 [../../Readme-CN.md](../../Readme-CN.md)。"
    return f"# {title}\n\n> 索引：[README.md](README.md) · 入口：[../Readme-CN.md](../Readme-CN.md)\n\n{body}\n"


def ensure_project_dir(project_dir: Path, package_id: str) -> None:
    docs = project_dir / "docs"
    docs.mkdir(exist_ok=True)

    readme_en = (project_dir / "Readme.md").read_text(encoding="utf-8") if (project_dir / "Readme.md").is_file() else ""
    readme_cn = (project_dir / "Readme-CN.md").read_text(encoding="utf-8") if (project_dir / "Readme-CN.md").is_file() else ""

    idx_en, idx_cn = rel_to_repo_index(project_dir)
    root_en = (
        load("MODULE_ROOT_DOCS_INDEX.en.template.md")
        .replace("{PackageId}", package_id)
        .replace("../../../docs/modules/README.md", idx_en)
        .replace("Repository-wide module list", "Repository project docs index")
    )
    root_cn = (
        load("MODULE_ROOT_DOCS_INDEX.cn.template.md")
        .replace("{PackageId}", package_id)
        .replace("../../../docs/modules/Readme-CN.md", idx_cn)
        .replace("全仓库模块列表", "全仓库项目文档索引")
    )
    (project_dir / "Docs-Index.md").write_text(root_en, encoding="utf-8", newline="\n")
    (project_dir / "Docs-Index-CN.md").write_text(root_cn, encoding="utf-8", newline="\n")

    en = docs / "en"
    zh = docs / "zh-cn"
    en.mkdir(exist_ok=True)
    zh.mkdir(exist_ok=True)

    for fname, tpl in (
        ("README.md", "PROJECT_DOCS_GATEWAY.en.template.md"),
        ("Readme-CN.md", "PROJECT_DOCS_GATEWAY.cn.template.md"),
    ):
        (docs / fname).write_text(load(tpl).replace("{PackageId}", package_id), encoding="utf-8", newline="\n")
    (en / "README.md").write_text(
        load("PROJECT_DOCS_LOCALE_INDEX.en.template.md").replace("{PackageId}", package_id),
        encoding="utf-8",
        newline="\n",
    )
    (zh / "README.md").write_text(
        load("PROJECT_DOCS_LOCALE_INDEX.cn.template.md").replace("{PackageId}", package_id),
        encoding="utf-8",
        newline="\n",
    )

    quick_en = extract_flex(readme_en, ["Quick start", "How to use", "Usage"])
    quick_cn = extract_flex(readme_cn, ["快速开始", "使用方式", "How to use"])
    usage_en = extract_flex(
        readme_en,
        ["Usage (developers)", "Usage (site owners", "Usage", "使用方式 | Usage", "Upgrade & extension"],
    )
    usage_cn = extract_flex(readme_cn, ["使用方式（开发）", "使用方式（站点", "使用方式", "升级与扩展"])
    cfg_en = extract_flex(readme_en, ["Configuration", "Dependencies", "配置说明 | Dependencies"])
    cfg_cn = extract_flex(readme_cn, ["配置", "依赖说明"])
    caut_en = extract_flex(readme_en, ["Pitfalls & cautions", "Cautions", "Out of scope", "Upgrade & extension"])
    caut_cn = extract_flex(readme_cn, ["注意事项", "不实现", "升级与扩展"])

    (en / "QuickStart.md").write_text(topic_stub_en("Quick start", quick_en), encoding="utf-8", newline="\n")
    (zh / "QuickStart.md").write_text(topic_stub_cn("快速开始", quick_cn), encoding="utf-8", newline="\n")
    (en / "Usage.md").write_text(topic_stub_en("Usage", usage_en), encoding="utf-8", newline="\n")
    (zh / "Usage.md").write_text(topic_stub_cn("使用方式", usage_cn), encoding="utf-8", newline="\n")
    (en / "Configuration.md").write_text(topic_stub_en("Configuration", cfg_en), encoding="utf-8", newline="\n")
    (zh / "Configuration.md").write_text(topic_stub_cn("配置", cfg_cn), encoding="utf-8", newline="\n")
    (en / "Cautions.md").write_text(topic_stub_en("Pitfalls & cautions", caut_en), encoding="utf-8", newline="\n")
    (zh / "Cautions.md").write_text(topic_stub_cn("注意事项与常见坑", caut_cn), encoding="utf-8", newline="\n")

    for legacy in docs.glob("*-CN.md"):
        legacy.unlink(missing_ok=True)
    for topic in ("QuickStart.md", "Usage.md", "Configuration.md", "Cautions.md"):
        p = docs / topic
        if p.is_file():
            p.unlink(missing_ok=True)


def write_repo_index(projects: list[Path]) -> None:
    REPO_INDEX_EN.parent.mkdir(parents=True, exist_ok=True)
    by_area: dict[str, list[tuple[str, Path]]] = {a: [] for a in AREA_ORDER}
    for csproj in projects:
        rel = csproj.parent.relative_to(SRC)
        area = rel.parts[0] if rel.parts else "Other"
        if area not in by_area:
            by_area[area] = []
        by_area[area].append((csproj.stem, csproj.parent))

    def render_table(rows: list[tuple[str, Path]], lang: str) -> list[str]:
        lines: list[str] = []
        for pkg, pdir in rows:
            rel = pdir.relative_to(ROOT).as_posix()
            if lang == "en":
                lines.append(
                    f"| `{pkg}` | [Docs-Index.md](../../{rel}/Docs-Index.md) | "
                    f"[en](../../{rel}/docs/en/README.md) · [zh-cn](../../{rel}/docs/zh-cn/README.md) |"
                )
            else:
                lines.append(
                    f"| `{pkg}` | [Docs-Index-CN.md](../../{rel}/Docs-Index-CN.md) | "
                    f"[zh-cn](../../{rel}/docs/zh-cn/README.md) |"
                )
        return lines

    en: list[str] = [
        "# `src/` projects — documentation index",
        "",
        "> **中文**: [Readme-CN.md](Readme-CN.md) · **Tree**: [../../src/README.md](../../src/README.md)",
        "",
        "Every **non-test** project directory under `src/` (with a `.csproj`) **must** have:",
        "",
        "- `Docs-Index.md` / `Docs-Index-CN.md`",
        "- `docs/en/` and `docs/zh-cn/` with `QuickStart`, `Usage`, `Configuration`, `Cautions`",
        "",
        "**Excluded**: entire `src/Test/`, `*.Tests*`, `*.Tests.UI*`, `*.Tester*`, benchmarks.",
        "",
        "Regenerate: `python scripts/Restructure-ProjectDocsEnZhCn.py`",
        "",
    ]
    cn: list[str] = [
        "# `src/` 项目 — 文档总索引",
        "",
        "> **English**: [README.md](README.md) · **代码树**: [../../src/Readme-CN.md](../../src/Readme-CN.md)",
        "",
        "凡 `src/` 下**非测试**项目目录（含 `.csproj`）**必须**具备：`Docs-Index`、`docs/en/`、`docs/zh-cn/` 分主题文档。",
        "",
        "**排除**：`src/Test/` 全文、`*.Tests*`、`*.Tests.UI*`、`*.Tester*`、Benchmark。",
        "",
        "批量生成：`python scripts/Ensure-ProjectDocsFolders.py`",
        "",
    ]
    for area in list(AREA_ORDER) + [k for k in sorted(by_area) if k not in AREA_ORDER]:
        rows = sorted(by_area.get(area, []), key=lambda x: x[0])
        if not rows:
            continue
        en += [f"## {area}", "", "| Package | Docs index | Topics |", "|---------|------------|--------|"]
        en += render_table(rows, "en")
        en.append("")
        cn += [f"## {area}", "", "| PackageId | 文档索引 | 分主题 |", "|-----------|----------|--------|"]
        cn += render_table(rows, "cn")
        cn.append("")

    REPO_INDEX_EN.write_text("\n".join(en) + "\n", encoding="utf-8", newline="\n")
    REPO_INDEX_CN.write_text("\n".join(cn) + "\n", encoding="utf-8", newline="\n")

    # Keep modules shortcut index in sync
    mods = ROOT / "docs" / "modules"
    mods.mkdir(exist_ok=True)
    mod_en = (
        "# Orchard modules — documentation index\n\n"
        "> **Full `src/` index**: [../src-projects/README.md](../src-projects/README.md)\n\n"
        "See **Modules** section in the parent index.\n"
    )
    mod_cn = (
        "# Orchard 模块 — 文档索引\n\n"
        "> **完整 `src/` 索引**：[../src-projects/Readme-CN.md](../src-projects/Readme-CN.md)\n\n"
        "模块列表见上级索引 **Modules** 一节。\n"
    )
    (mods / "README.md").write_text(mod_en, encoding="utf-8", newline="\n")
    (mods / "Readme-CN.md").write_text(mod_cn, encoding="utf-8", newline="\n")


def main() -> None:
    projects = collect_projects()
    seen: set[Path] = set()
    for csproj in projects:
        pdir = csproj.parent.resolve()
        if pdir in seen:
            continue
        seen.add(pdir)
        ensure_project_dir(pdir, csproj.stem)
    write_repo_index(projects)
    print(f"Ensured docs/ for {len(seen)} project directories ({len(projects)} csproj files, tests excluded).")


if __name__ == "__main__":
    main()