#!/usr/bin/env python3
"""Ensure each src csproj folder has detailed Readme.md (EN) and Readme-CN.md (ZH)."""

from __future__ import annotations

import argparse
import re
import xml.etree.ElementTree as ET
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SRC = ROOT / "src"
EN_TEMPLATE = ROOT / "docs/templates/PROJECT_README.en.template.md"
CN_TEMPLATE = ROOT / "docs/templates/PROJECT_README.cn.template.md"

PKG_REF = re.compile(r'<PackageReference\s+Include="([^"]+)"(?:\s+Version="([^"]+)")?')
PROJ_REF = re.compile(r'<ProjectReference\s+Include="([^"]+)"')


def load_text(path: Path) -> str:
    return path.read_text(encoding="utf-8") if path.is_file() else ""


def parse_csproj(csproj: Path) -> dict:
    text = load_text(csproj)
    props: dict[str, str] = {}
    for tag in ("PackageId", "AssemblyName", "RootNamespace", "TargetFramework", "Title", "DescriptionBody"):
        m = re.search(rf"<{tag}>([^<]+)</{tag}>", text)
        if m:
            props[tag] = m.group(1).strip()
    package_id = props.get("PackageId") or csproj.stem
    pkg_refs = [(m.group(1), m.group(2) or "central") for m in PKG_REF.finditer(text)]
    proj_refs = [m.group(1) for m in PROJ_REF.finditer(text)]
    return {
        "package_id": package_id,
        "title": props.get("Title") or package_id,
        "description": props.get("DescriptionBody", ""),
        "target_framework": props.get("TargetFramework", "net10.0"),
        "pkg_refs": pkg_refs,
        "proj_refs": proj_refs,
        "path": csproj,
    }


def classify(package_id: str) -> str:
    if package_id.endswith(".Tests.UI"):
        return "tests-ui"
    if ".Tests." in package_id or package_id.endswith(".Tests"):
        return "tests"
    if package_id.endswith(".Samples"):
        return "samples"
    if package_id.startswith("Smartent.Build."):
        return "build"
    if package_id.startswith("Smartent.Core."):
        return "core"
    if package_id.startswith("Smartent.Orchard."):
        if ".Theme." in package_id:
            return "theme"
        if ".Hosting." in package_id:
            return "hosting"
        return "module"
    if package_id.startswith("Smartent.Test."):
        return "test-tooling"
    if package_id.startswith("Smartent.Demo."):
        return "demo"
    return "library"


def role_copy(role: str, meta: dict) -> dict[str, str]:
    desc = meta["description"] or meta["title"]
    orch = "Orchard Core module" if role in {"module", "hosting", "theme"} else "—"
    orch_cn = "Orchard Core 模块" if role in {"module", "hosting", "theme"} else "—"

    usage_en = {
        "build": "Import the Sdk or targets from your `.csproj` / `Directory.Build.props` per `src/Build/docs/UsingMSBuildSdks.md`.",
        "core": "Reference as a library; no Orchard feature is required.",
        "module": "Add the module to the host (`Program` / `Startup`), enable features in Admin → Configuration → Features, and run Recipes if provided under `Recipes/`.",
        "hosting": "Enable tenant/hosting features and set `OrchardCore:Smartent_Orchard_Hosting_*` sections in `appsettings.json`.",
        "theme": "Enable the theme feature and set it as the site or admin theme.",
        "tests-ui": "Reference from a UI test project; run with `Smartent.Test.UI` and the main solution filter.",
        "tests": "Run unit tests with `dotnet test` on this project.",
        "samples": "Enable together with the parent module in `Smartent.Demo.Web` or your sample host.",
        "test-tooling": "Reference from test projects; configure via `TestConfiguration.json` or `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION`.",
        "demo": "Run as the startup project: `dotnet run --project Smartent.Demo.Web.csproj`.",
        "library": "Reference as a library from modules or the demo web app.",
    }.get(role, "See parent solution documentation.")

    usage_cn = {
        "build": "在 `.csproj` 或 `Directory.Build.props` 中按 `src/Build/docs/UsingMSBuildSdks.md` 引用 Sdk/targets。",
        "core": "作为类库引用；无需启用 Orchard 功能。",
        "module": "将模块加入宿主，在后台「配置 → 功能」启用，并按需执行 `Recipes/` 下的配方。",
        "hosting": "启用租户/托管相关功能，并在 `appsettings.json` 配置 `OrchardCore:Smartent_Orchard_Hosting_*`。",
        "theme": "启用主题功能并设为站点或后台主题。",
        "tests-ui": "由 UI 测试项目引用；配合 `Smartent.Test.UI` 与主解决方案运行。",
        "tests": "使用 `dotnet test` 运行本单元测试项目。",
        "samples": "与父模块一起在 `Smartent.Demo.Web` 或样例宿主中启用。",
        "test-tooling": "测试项目引用；通过 `TestConfiguration.json` 或环境变量 `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION` 配置。",
        "demo": "作为启动项目：`dotnet run --project Smartent.Demo.Web.csproj`。",
        "library": "由模块或 Demo Web 以 ProjectReference 引用。",
    }.get(role, "见上级解决方案文档。")

    out_scope_en = {
        "tests-ui": "Not shipped as a runtime module.",
        "tests": "Not shipped to production.",
        "samples": "Demonstration content only; not for production sites.",
        "demo": "Local training host only.",
    }.get(role, "Does not replace Orchard Core built-in features unless documented.")

    out_scope_cn = {
        "tests-ui": "非运行时模块，不参与站点发布。",
        "tests": "仅测试用途，不进入生产部署。",
        "samples": "仅演示内容与配方，不用于生产站点。",
        "demo": "本地培训/演示宿主。",
    }.get(role, "除非文档说明，不替代 Orchard Core 内置能力。")

    ext_en = {
        "module": "Drivers, handlers, shapes, and `IDataTableDataProvider`-style interfaces (see source).",
        "build": "MSBuild targets and Sdk hooks in `build/*.targets`.",
        "test-tooling": "UI test context extensions and recipes under `Smartent.Test.UI.*`.",
    }.get(role, "Public APIs documented with Chinese XML comments in source.")

    ext_cn = {
        "module": "Driver/Handler/Shape 及模块内接口（见源码）。",
        "build": "Sdk 与 `build/*.targets` 中的 MSBuild 扩展点。",
        "test-tooling": "`Smartent.Test.UI.*` 下的测试扩展与配方。",
    }.get(role, "公共 API 见源码中文 XML 注释。")

    return {
        "summary_en": desc[:500] if desc else f"{meta['package_id']} — Smartent Orchard Extensions component.",
        "summary_cn": f"{meta['package_id']}：Smartent Orchard Extensions 组件。{desc[:300] if desc else ''}",
        "features_implement_en": desc[:400] if desc else f"Provides `{meta['package_id']}` APIs.",
        "features_implement_cn": f"{meta['title']}：{desc[:400]}" if desc else f"提供 `{meta['package_id']}` 能力。",
        "features_out_en": out_scope_en,
        "features_out_cn": out_scope_cn,
        "usage_en": usage_en,
        "usage_cn": usage_cn,
        "orchard_features": orch,
        "orchard_features_cn": orch_cn,
        "ext_en": ext_en,
        "ext_cn": ext_cn,
    }


def dependency_table(pkg_refs: list[tuple[str, str]]) -> tuple[str, str]:
    if not pkg_refs:
        return "| — | — | No direct PackageReference (may use central props) |", "| — | — | 无直接 PackageReference（可能由中央版本管理） |"
    rows_en = []
    rows_cn = []
    for name, ver in pkg_refs[:25]:
        rows_en.append(f"| `{name}` | Package | Version `{ver}` |")
        rows_cn.append(f"| `{name}` | 包引用 | 版本 `{ver}` |")
    if len(pkg_refs) > 25:
        rows_en.append(f"| … | | +{len(pkg_refs) - 25} more |")
        rows_cn.append(f"| … | | 另有 {len(pkg_refs) - 25} 项 |")
    return "\n".join(rows_en), "\n".join(rows_cn)


def find_manifest_features(project_dir: Path) -> str:
    for manifest in project_dir.rglob("Manifest.cs"):
        text = load_text(manifest)
        ids = re.findall(r'\[assembly:\s*Feature\([^\]]*Id\s*=\s*"([^"]+)"', text)
        if not ids:
            ids = re.findall(r'Id\s*=\s*"([^"]+)"', text)
        if ids:
            return ", ".join(ids[:8])
    return "（见 Manifest / Module.cs）" if any(project_dir.rglob("Manifest.cs")) else "N/A"


def parse_package_json(project_dir: Path) -> str:
    pkg = project_dir / "package.json"
    if not pkg.is_file():
        return "| — | — | — | — |"
    try:
        import json

        data = json.loads(pkg.read_text(encoding="utf-8"))
    except Exception:
        return "| — | — | parse error | — |"
    rows = []
    for section in ("dependencies", "devDependencies"):
        block = data.get(section) or {}
        for name, ver in list(block.items())[:12]:
            rows.append(f"| `{name}` | {ver} | {section} | see package.json scripts |")
    return "\n".join(rows) if rows else "| — | — | — | see package.json |"


def sibling_test(meta: dict) -> str:
    csproj = meta["path"]
    stem = csproj.stem
    for suffix in (".Tests", ".Tests.UI"):
        candidate = csproj.with_name(stem + suffix + ".csproj")
        if candidate.is_file():
            return candidate.relative_to(ROOT).as_posix()
    # parent folder Tests
    parent = csproj.parent.parent
    for pattern in (f"{stem}.Tests.csproj", f"{stem}.Tests.UI.csproj"):
        c = parent / pattern.replace(stem, stem.split(".")[-0])
    tests = list(parent.glob(f"*{stem.split('.')[-1]}*.Tests*.csproj"))
    if tests:
        return tests[0].relative_to(ROOT).as_posix()
    return csproj.relative_to(ROOT).as_posix()


def project_ref_example(meta: dict) -> str:
    if meta["proj_refs"]:
        return meta["proj_refs"][0].replace("\\", "/")
    return meta["path"].relative_to(ROOT).as_posix()


def fill_template(template: str, values: dict[str, str]) -> str:
    out = template
    for key, val in values.items():
        out = out.replace("{" + key + "}", val)
    return out


def ensure_header(readme: Path, other_name: str, lang_label: str) -> str:
    text = load_text(readme)
    if other_name in text[:800]:
        return text
    header = f"\n> **{lang_label}**: [{other_name}]({other_name})\n\n"
    if not text.strip():
        return header.lstrip()
    lines = text.splitlines()
    if lines and lines[0].startswith("#"):
        return lines[0] + header + "\n".join(lines[1:])
    return header + text


def write_if_needed(path: Path, content: str, force: bool) -> bool:
    if path.is_file() and not force:
        existing = load_text(path)
        if len(existing.strip()) > 200 and "依赖说明" in existing or "Dependencies" in existing:
            if "Readme-CN.md" in existing[:500] or path.name == "Readme-CN.md":
                return False
        if path.name == "Readme-CN.md" and len(existing) > 150:
            return False
    path.write_text(content.rstrip() + "\n", encoding="utf-8", newline="\n")
    return True


def process_csproj(csproj: Path, force: bool, verbose: bool) -> tuple[bool, bool]:
    project_dir = csproj.parent
    meta = parse_csproj(csproj)
    role = classify(meta["package_id"])
    copy = role_copy(role, meta)
    dep_en, dep_cn = dependency_table(meta["pkg_refs"])
    repo_rel = project_dir.relative_to(ROOT).as_posix()
    csproj_rel = csproj.relative_to(ROOT).as_posix()
    test_rel = sibling_test(meta)
    ref_ex = meta["proj_refs"][0].replace("\\", "/") if meta["proj_refs"] else csproj_rel
    features = find_manifest_features(project_dir)
    npm_table = parse_package_json(project_dir)

    en_tpl = load_text(EN_TEMPLATE)
    cn_tpl = load_text(CN_TEMPLATE)
    common = {
        "PackageId": meta["package_id"],
        "RepoRelativePath": repo_rel,
        "ProjectReferenceExample": ref_ex,
        "CsprojRelativeFromRepoRoot": csproj_rel,
        "TestCsprojOrSame": test_rel,
        "OrchardFeatures": features if features != "N/A" else copy["orchard_features"],
        "OrchardFeaturesCn": features if features != "N/A" else copy["orchard_features_cn"],
        "DependencyTableEn": dep_en,
        "DependencyTableCn": dep_cn,
        "NpmTableOrDash": npm_table,
        "AdditionalTestNotesEn": "UI tests: filter `*.Tests.UI.csproj` in the solution.",
        "AdditionalTestNotesCn": "UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。",
    }
    en_vals = {
        **common,
        "SummaryEn": copy["summary_en"],
        "FeaturesImplementEn": copy["features_implement_en"],
        "FeaturesOutOfScopeEn": copy["features_out_en"],
        "UsageStepsEn": copy["usage_en"],
        "ExtensionPointsEn": copy["ext_en"],
    }
    cn_vals = {
        **common,
        "SummaryCn": copy["summary_cn"],
        "FeaturesImplementCn": copy["features_implement_cn"],
        "FeaturesOutOfScopeCn": copy["features_out_cn"],
        "UsageStepsCn": copy["usage_cn"],
        "ExtensionPointsCn": copy["ext_cn"],
    }

    readme_en = project_dir / "Readme.md"
    readme_cn = project_dir / "Readme-CN.md"
    existing_en = load_text(readme_en)

    wrote_en = False
    wrote_cn = False

    if len(existing_en.strip()) < 120 or force:
        content = fill_template(en_tpl, en_vals)
        wrote_en = write_if_needed(readme_en, content, force)
    else:
        new_en = ensure_header(readme_en, "Readme-CN.md", "中文说明")
        if new_en != existing_en:
            readme_en.write_text(new_en, encoding="utf-8", newline="\n")
            wrote_en = True

    if not readme_cn.is_file() or force:
        content_cn = fill_template(cn_tpl, cn_vals)
        wrote_cn = write_if_needed(readme_cn, content_cn, force)
    elif len(load_text(readme_cn)) < 150:
        content_cn = fill_template(cn_tpl, cn_vals)
        wrote_cn = write_if_needed(readme_cn, content_cn, True)

    if verbose and (wrote_en or wrote_cn):
        print(f"  {repo_rel}: en={wrote_en} cn={wrote_cn}")
    return wrote_en, wrote_cn


def module_solution_readmes(force: bool) -> int:
    """Folders with sln + Readme.md but csproj in subfolder (e.g. DataTables root)."""
    count = 0
    for sln in SRC.rglob("*.sln"):
        folder = sln.parent
        readme = folder / "Readme.md"
        if not readme.is_file():
            continue
        if (folder / "Readme-CN.md").is_file() and not force:
            continue
        # pick main csproj in subdirs (not Tests/Samples)
        candidates = [
            p
            for p in folder.rglob("*.csproj")
            if ".Tests" not in p.stem and ".Samples" not in p.stem and p.parent != folder
        ]
        if not candidates:
            continue
        main = sorted(candidates, key=lambda p: len(p.parts))[0]
        meta = parse_csproj(main)
        _, wrote_cn = process_csproj(main, force=False, verbose=False)
        cn_path = folder / "Readme-CN.md"
        if not cn_path.is_file():
            # generate CN at solution root from main module meta
            role = classify(meta["package_id"])
            copy = role_copy(role, meta)
            dep_en, dep_cn = dependency_table(meta["pkg_refs"])
            cn_tpl = load_text(CN_TEMPLATE)
            vals = {
                "PackageId": meta["package_id"] + " (solution)",
                "RepoRelativePath": folder.relative_to(ROOT).as_posix(),
                "ProjectReferenceExample": main.relative_to(folder).as_posix(),
                "CsprojRelativeFromRepoRoot": main.relative_to(ROOT).as_posix(),
                "TestCsprojOrSame": main.relative_to(ROOT).as_posix(),
                "OrchardFeaturesCn": find_manifest_features(main.parent),
                "DependencyTableCn": dep_cn,
                "NpmTableOrDash": "| — | — | — | — |",
                "SummaryCn": f"本目录为 `{meta['package_id']}` 解决方案根。中文细节见子项目 Readme-CN.md；英文总览见 [Readme.md](Readme.md)。\n\n{copy['summary_cn']}",
                "FeaturesImplementCn": f"- 包含主模块及 Samples/Tests 子工程。\n{copy['features_implement_cn']}",
                "FeaturesOutOfScopeCn": copy["features_out_cn"],
                "UsageStepsCn": copy["usage_cn"],
                "ExtensionPointsCn": copy["ext_cn"],
                "AdditionalTestNotesCn": "子项目各自含 Readme-CN.md。",
            }
            cn_path.write_text(fill_template(cn_tpl, vals).rstrip() + "\n", encoding="utf-8", newline="\n")
            count += 1
        en_text = load_text(readme)
        if "Readme-CN.md" not in en_text[:600]:
            readme.write_text(ensure_header(readme, "Readme-CN.md", "中文说明"), encoding="utf-8", newline="\n")
    return count


def main() -> None:
    parser = argparse.ArgumentParser()
    parser.add_argument("--force", action="store_true", help="Regenerate even when Readme looks complete")
    parser.add_argument("--verbose", action="store_true")
    args = parser.parse_args()

    csprojs = sorted(p for p in SRC.rglob("*.csproj") if "obj" not in p.parts and "bin" not in p.parts)
    en_count = cn_count = 0
    for csproj in csprojs:
        w_en, w_cn = process_csproj(csproj, args.force, args.verbose)
        en_count += int(w_en)
        cn_count += int(w_cn)

    module_roots = module_solution_readmes(args.force)
    print(f"Processed {len(csprojs)} csproj folders. Updated Readme.md: {en_count}, Readme-CN.md: {cn_count + module_roots}.")


if __name__ == "__main__":
    main()