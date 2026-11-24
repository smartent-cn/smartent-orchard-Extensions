#!/usr/bin/env python3
"""Thicken Readme.md / Readme-CN.md for src/Modules using MODULE_* templates."""

from __future__ import annotations

import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
MODULES = ROOT / "src" / "Modules"
EN_TPL = (ROOT / "docs/templates/MODULE_README.en.template.md").read_text(encoding="utf-8")
CN_TPL = (ROOT / "docs/templates/MODULE_README.cn.template.md").read_text(encoding="utf-8")

FEATURE_BLOCK = re.compile(
    r"\[assembly:\s*Feature\(\s*(.*?)\)\s*\]",
    re.DOTALL,
)
KV = re.compile(r'(\w+)\s*=\s*"([^"]*)"')
CONFIG_CONST = re.compile(
    r'public\s+(?:const|static\s+readonly)\s+string\s+(\w+)\s*=\s*"([^"]+)"'
)

MODULE_FAMILIES_ORDER: list[str] = [
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
]

# Optional human-authored overlays (EN / CN tuples per section key).
PROFILES: dict[str, dict[str, tuple[str, str]]] = {
    "Smartent.Orchard.AuditTrail": {
        "when": (
            "Use when you need version-style access to content history via Audit Trail events beyond stock OrchardCore.AuditTrail.",
            "需要在 Audit Trail 事件基础上按“版本”思路读取内容历史、而不仅依赖内置 Versionable 时使用。",
        ),
        "admin": (
            "No dedicated admin menu; features register services used from code and other modules.",
            "无独立后台菜单；能力以服务形式供代码或其它模块调用。",
        ),
        "dev": (
            "Inject `IAuditTrailContentVersionNumberService` in handlers or services. Requires **OrchardCore.AuditTrail** enabled.",
            "在 Handler/Service 中注入 `IAuditTrailContentVersionNumberService`；须先启用 **OrchardCore.AuditTrail**。",
        ),
        "cautions": (
            "- Depends on Audit Trail event retention; purging audit logs affects history.\n"
            "- Not a replacement for **Versionable** content definitions unless you design for it.",
            "- 依赖 Audit Trail 保留策略；清理审计日志会影响历史查询。\n"
            "- 不能自动替代 **Versionable** 内容定义，需自行建模。",
        ),
    },
    "Smartent.Orchard.ChartJs": {
        "when": (
            "Use for Chart.js widgets, admin charts, and sample dashboards in Orchard Core.",
            "在 Orchard Core 中展示 Chart.js 图表、后台统计或样例仪表盘时使用。",
        ),
        "admin": (
            "Enable feature, add Chart widgets or use samples; see `Smartent.Orchard.ChartJs.Samples` recipes.",
            "启用功能后使用 Chart 组件或运行 Samples 配方；参见 `Smartent.Orchard.ChartJs.Samples`。",
        ),
        "dev": (
            "Reference module, register Chart.js resources via shapes/widgets. Sample CSS class: `smartentChartJsSamplesChartContainer`.",
            "引用模块后通过 Shape/Widget 使用 Chart.js 资源；样例容器 class：`smartentChartJsSamplesChartContainer`。",
        ),
        "cautions": (
            "- Load Chart.js only on pages that need charts (resource management).\n"
            "- Align Chart.js version with bundled scripts in `wwwroot`.",
            "- 仅在需要图表的页面注册资源，避免全站加载 Chart.js。\n"
            "- 升级时注意 `wwwroot` 内脚本版本与模块一致。",
        ),
    },
    "Smartent.Orchard.DataTables": {
        "when": (
            "Sortable/searchable tables from custom data providers, admin grids, or DOM/tag-helper tables.",
            "需要可排序/可搜索表格、后台数据网格或 DOM/标签助手表格时使用。",
        ),
        "admin": (
            "Use `/Admin/DataTable/{providerName}/{queryId?}` for single-table admin pages; enable Samples for demos.",
            "单表后台页访问 `/Admin/DataTable/{providerName}/{queryId?}`；可启用 Samples 查看演示。",
        ),
        "dev": (
            "Implement `IDataTableDataProvider`, register with `AddDataTableDataProvider<T>()`. JS plugin: `smartent_DataTables`; events `.smartentdt`.",
            "实现 `IDataTableDataProvider` 并用 `AddDataTableDataProvider<T>()` 注册；前端 `smartent_DataTables`，事件命名空间 `.smartentdt`。",
        ),
        "cautions": (
            "- Index-based providers need migrations/recipes for index rebuild.\n"
            "- Heavy queries: prefer `IndexBasedDataTableDataProvider` over on-demand SQL.",
            "- 索引型 Provider 需配方/迁移重建索引。\n"
            "- 重查询优先用 `IndexBasedDataTableDataProvider`，避免按需全表扫描。",
        ),
    },
    "Smartent.Orchard.VueJs": {
        "when": (
            "Host Vue 3 SFC components in Orchard shapes/pages with build pipeline integration.",
            "在 Orchard 页面/Shape 中托管 Vue 3 单文件组件并走统一前端构建时使用。",
        ),
        "dev": (
            "Use `vue-component-app` tag helper / `.smartent-vue` root; run `pnpm` scripts via `Smartent.Build.NodeJs`. Package name: `smartent-vuejs`.",
            "使用 `vue-component-app` 标签助手或 `.smartent-vue` 根节点；经 `Smartent.Build.NodeJs` 执行 `pnpm`；npm 包名 `smartent-vuejs`。",
        ),
        "cautions": (
            "- Requires Node/pnpm for asset build before `dotnet build` when scripts change.\n"
            "- CSP may block inline Vue hydration; align with `Smartent.Orchard.Platform` CSP module.",
            "- 修改脚本后需先跑 Node/pnpm 再 `dotnet build`。\n"
            "- CSP 可能阻止 Vue 内联初始化；与平台 CSP 模块对齐。",
        ),
    },
    "Smartent.Orchard.Privacy": {
        "when": (
            "GDPR-style consent banner, registration checkbox, and privacy widgets.",
            "需要同意横幅、注册勾选框等隐私合规 UI 时使用。",
        ),
        "cautions": (
            "- Legal text is your responsibility; module provides mechanics only.\n"
            "- Shapes use `Smartent_Orchard_Privacy_*` ids; update theme overrides accordingly.",
            "- 法律文案由站点自行负责；模块仅提供机制。\n"
            "- Shape 使用 `Smartent_Orchard_Privacy_*`；主题覆盖需同步更新。",
        ),
    },
    "Smartent.Orchard.Marketing": {
        "when": (
            "Pirsch analytics, URL shortener, and marketing tracking integration.",
            "集成 Pirsch 统计、短链接与营销追踪时使用。",
        ),
        "dev": (
            "Configure `OrchardCore:Smartent_Marketing` in `appsettings.json`; submodules: `Smartent.Orchard.Marketing.Pirsch`, `.UrlShortener`.",
            "在 `appsettings.json` 配置 `OrchardCore:Smartent_Marketing`；子包：`Smartent.Orchard.Marketing.Pirsch`、`.UrlShortener`。",
        ),
        "cautions": (
            "- Do not commit Pirsch tokens; use secrets.\n"
            "- Short links migrations seed example campaigns only.",
            "- 勿将 Pirsch 令牌提交 git；使用 User Secrets。\n"
            "- 短链迁移仅含示例活动数据。",
        ),
    },
    "Smartent.Orchard.Hosting.Tenants": {
        "when": (
            "Multi-tenant SaaS: tenant admin login, quotas, robots, health, maintenance, media storage, etc.",
            "多租户 SaaS：租户后台登录、配额、robots、健康检查、维护、媒体存储等。",
        ),
        "cautions": (
            "- Each sub-package has its own Feature; enable only what the environment needs.\n"
            "- Configuration keys use `Smartent_Orchard_Hosting_*` prefixes.",
            "- 各子包独立 Feature；只启用环境所需能力。\n"
            "- 配置键前缀为 `Smartent_Orchard_Hosting_*`。",
        ),
    },
    "Smartent.Orchard.LoginAsAnybody": {
        "when": (
            "Development/staging only: impersonate users for support or QA.",
            "仅开发/预发：客服或 QA 模拟登录其他用户。",
        ),
        "cautions": (
            "- **Never enable in production** without strict network and role controls.\n"
            "- Audit all impersonation actions.",
            "- **切勿在生产**无网络与角色隔离时启用。\n"
            "- 须记录并审计所有模拟登录行为。",
        ),
    },
    "Smartent.Orchard.ContentEditors": {
        "when": (
            "Custom admin content editors (dropdowns, links, macros) beyond stock Orchard editors.",
            "需要自定义后台内容编辑器（下拉、链接、宏等）时使用。",
        ),
        "admin": (
            "Attach editors to content parts via content definition; see Samples recipes.",
            "在内容定义中为 Part 挂载编辑器；参考 Samples 配方。",
        ),
        "cautions": (
            "- Editors are tenant-specific; deploy recipes per environment.",
            "- 编辑器按租户配置；每环境单独部署配方。",
        ),
    },
    "Smartent.Orchard.EmailClient": {
        "when": (
            "IMAP/sync email inside Orchard admin for support or editorial workflows.",
            "在 Orchard 后台集成 IMAP/同步邮件时使用。",
        ),
        "admin": (
            "Configure account under module settings after enabling feature; use Samples for demo mailboxes.",
            "启用功能后在模块设置中配置邮箱；Samples 提供演示。",
        ),
        "cautions": (
            "- Store credentials in secrets, not `appsettings` committed to git.\n"
            "- Rate limits apply on public IMAP providers.",
            "- 凭证放入 User Secrets，勿提交仓库。\n"
            "- 公共 IMAP 有频率限制。",
        ),
    },
    "Smartent.Orchard.Extensions.Cms": {
        "when": (
            "Extra CMS widgets, recipes, and Orchard recipe migration helpers (Helpful Extensions successor).",
            "需要额外 CMS 小组件、配方及 Recipe 迁移辅助时使用。",
        ),
        "dev": (
            "Enable selected features only; see `Extensions/OrchardRecipeMigration` docs in-project.",
            "按需启用子 Feature；Recipe 迁移见项目内 `Extensions/OrchardRecipeMigration` 文档。",
        ),
        "cautions": (
            "- Large surface area—enable features incrementally to avoid unused dependencies.",
            "- 功能面大，建议逐项启用，避免无用依赖。",
        ),
    },
    "Smartent.Orchard.Hosting.ApplicationInsights": {
        "when": (
            "Send Orchard telemetry to Azure Application Insights on multi-tenant hosts.",
            "多租户宿主将 Orchard 遥测发往 Azure Application Insights 时使用。",
        ),
        "dev": (
            "Set `OrchardCore:Smartent_Orchard_Hosting_ApplicationInsights` (connection string / instrumentation key per docs).",
            "配置 `OrchardCore:Smartent_Orchard_Hosting_ApplicationInsights`（连接字符串见模块 Readme）。",
        ),
        "cautions": (
            "- Keys are secrets; use environment-specific configuration.\n"
            "- Sampling may hide rare errors—increase when debugging.",
            "- 密钥为敏感信息，分环境配置。\n"
            "- 采样可能掩盖偶发错误，调试时可调高采样。",
        ),
    },
    "Smartent.Orchard.Hosting.BuildVersion": {
        "when": (
            "Display build/deployment version on pages or layouts for support and staging visibility.",
            "在页面或布局展示构建/部署版本，便于支持与预发识别。",
        ),
        "admin": (
            "Enable feature; widget/shape uses DOM id `smartent-hosting-build-version-display-build-version`.",
            "启用功能；部件 DOM id 为 `smartent-hosting-build-version-display-build-version`。",
        ),
        "cautions": (
            "- Do not expose internal CI metadata to public sites without review.",
            "- 公开站点展示版本信息前请评估是否泄露内部信息。",
        ),
    },
    "Smartent.Orchard.JsonEditor": {
        "when": (
            "Edit JSON fields in admin with a structured editor instead of raw textarea.",
            "后台编辑 JSON 字段时需要结构化编辑器而非纯文本框。",
        ),
        "admin": (
            "Add JSON editor to content fields via migration or recipe in Samples.",
            "通过迁移或 Samples 配方为字段挂载 JSON 编辑器。",
        ),
        "cautions": (
            "- Large JSON payloads may slow admin UI; validate schema server-side.",
            "- 大 JSON 可能拖慢后台；服务端须做校验。",
        ),
    },
    "Smartent.Orchard.TrainingDemo": {
        "when": (
            "Training exercises and sample controllers for learning Orchard Core (demo only).",
            "Orchard Core 培训练习与示例控制器（仅演示）。",
        ),
        "dev": (
            "Configuration section: `OrchardCore:Smartent_TrainingDemo` only (no Lombiq fallback).",
            "配置节：`OrchardCore:Smartent_TrainingDemo`（无遗留节）。",
        ),
        "cautions": (
            "- Not for production sites; disable in live environments.",
            "- 不可用于生产；正式环境请禁用。",
        ),
    },
    "Smartent.Orchard.UIKit": {
        "when": (
            "Bootstrap-based shapes, admin editors, cards, carousels, and widget pack.",
            "需要 Bootstrap Shape、后台编辑器、卡片、轮播及 Widgets 子模块时使用。",
        ),
        "dev": (
            "Resource names use `Smartent*` prefix (e.g. `SmartentDropdownScript`); optional `Smartent.Orchard.UIKit.Widgets`.",
            "资源名前缀 `Smartent*`；可选子模块 `Smartent.Orchard.UIKit.Widgets`。",
        ),
        "cautions": (
            "- Override shapes in theme with correct resource dependencies.\n"
            "- Slick carousel requires jQuery and vendor scripts from module.",
            "- 主题覆盖 Shape 时保持资源依赖完整。\n"
            "- Slick 轮播依赖 jQuery 与模块自带脚本。",
        ),
    },
    "Smartent.Orchard.Walkthroughs": {
        "when": (
            "Guided on-site walkthroughs (Shepherd.js-style) for onboarding editors.",
            "站点内向导式新手引导（类 Shepherd）时使用。",
        ),
        "admin": (
            "Import `Smartent.Orchard.Walkthroughs.Setup.recipe.json` then configure walks in admin.",
            "导入 `Smartent.Orchard.Walkthroughs.Setup.recipe.json` 后在后台配置引导。",
        ),
        "cautions": (
            "- Walkthrough scripts run in admin/front UI; test after theme changes.",
            "- 引导脚本运行于前后台，换主题后须回归测试。",
        ),
    },
}


def read(path: Path) -> str:
    return path.read_text(encoding="utf-8") if path.is_file() else ""


def parse_features(manifest_text: str) -> list[dict[str, str]]:
    features = []
    for block in FEATURE_BLOCK.finditer(manifest_text):
        body = block.group(1).replace("\r", "")
        vals = dict(KV.findall(body))
        if "Id" not in vals:
            m_id = re.search(r"\bId\s*=\s*([\"']?)([^\"',\]\s]+)\1?", body)
            if m_id:
                vals["Id"] = m_id.group(2)
        deps = ""
        m = re.search(r"Dependencies\s*=\s*\[(.*?)\]", body, re.DOTALL)
        if m:
            deps = ", ".join(re.findall(r'"([^"]+)"', m.group(1)))
        features.append(
            {
                "Id": vals.get("Id", "?"),
                "Name": vals.get("Name", "?"),
                "Dependencies": deps or "—",
            }
        )
    return features


def resolve_feature_ids(project_dir: Path, features: list[dict[str, str]]) -> list[dict[str, str]]:
    fid_paths = list(project_dir.glob("Constants/FeatureIds.cs")) + list(
        project_dir.rglob("Constants/FeatureIds.cs")
    )
    if not fid_paths:
        return features
    text = read(fid_paths[0])
    literals = dict(re.findall(r'public\s+const\s+string\s+(\w+)\s*=\s*"([^"]+)"', text))
    aliases = dict(re.findall(r"public\s+const\s+string\s+(\w+)\s*=\s*(\w+)\s*;", text))
    const_map = {**literals}
    for _ in range(5):
        for name, target in aliases.items():
            if target in const_map and name not in const_map:
                const_map[name] = const_map[target]
    resolved: list[dict[str, str]] = []
    for f in features:
        fid = f["Id"]
        if fid in const_map:
            f = {**f, "Id": const_map[fid]}
        resolved.append(f)
    return resolved


def feature_table(features: list[dict[str, str]]) -> tuple[str, str]:
    if not features:
        return "| — | — | — |", "| — | — | — |"
    en = cn = ""
    for f in features:
        en += f"| `{f['Id']}` | {f['Name']} | {f['Dependencies']} |\n"
        cn += f"| `{f['Id']}` | {f['Name']} | {f['Dependencies']} |\n"
    return en.rstrip(), cn.rstrip()


def find_config_keys(project_dir: Path) -> list[str]:
    keys: list[str] = []
    for cs in project_dir.rglob("*.cs"):
        if "ConfigurationKeys" not in cs.name and "Configuration" not in cs.name:
            continue
        keys.extend(v for _, v in CONFIG_CONST.findall(read(cs)))
    return sorted(set(keys))


def list_recipes(project_dir: Path) -> list[str]:
    return sorted(
        str(p.relative_to(project_dir).as_posix())
        for p in project_dir.rglob("Recipes/*.recipe.json")
    )


def list_child_projects(module_root: Path) -> list[str]:
    lines = []
    for csproj in sorted(module_root.rglob("*.csproj")):
        if any(x in csproj.stem for x in (".Tests", ".Tests.UI", ".Tests.Theme")):
            rel = csproj.parent.relative_to(module_root).as_posix()
            lines.append(f"- `{rel}` — automated/UI tests")
        elif csproj.stem.endswith(".Samples"):
            lines.append(f"- `{csproj.parent.relative_to(module_root).as_posix()}` — samples & recipes")
        elif csproj.parent == module_root / csproj.stem:
            lines.append(f"- `{csproj.parent.relative_to(module_root).as_posix()}` — main module")
        else:
            lines.append(f"- `{csproj.parent.relative_to(module_root).as_posix()}` — `{csproj.stem}`")
    return lines[:20]


def main_csproj(module_root: Path) -> Path | None:
    named = module_root / module_root.name / f"{module_root.name}.csproj"
    if named.is_file():
        return named
    for p in module_root.rglob("*.csproj"):
        if p.stem == module_root.name:
            return p
    # Marketing base package lives in subfolder
    candidates = [
        p
        for p in module_root.rglob("*.csproj")
        if ".Tests" not in p.stem and ".Samples" not in p.stem and p.stem.count(".") >= 2
    ]
    return min(candidates, key=lambda p: len(p.parts)) if candidates else None


def description_from_csproj(csproj: Path) -> str:
    text = read(csproj)
    m = re.search(r"<DescriptionBody>([^<]+)</DescriptionBody>", text)
    return m.group(1).strip() if m else csproj.stem


def quick_start(module_name: str, main: Path, features: list[dict[str, str]], recipes: list[str]) -> tuple[str, str]:
    rel = main.relative_to(ROOT).as_posix()
    host_ref = f"../../../Modules/{module_name}/{module_name}/{module_name}.csproj"
    try:
        host_ref = main.relative_to(ROOT / "src" / "Demo" / "Smartent.Demo.Web").as_posix()
    except ValueError:
        parts = main.relative_to(MODULES).parts
        ups = "/".join([".."] * 3)
        host_ref = f"{ups}/Modules/{'/'.join(parts)}"
    feat = features[0]["Id"] if features else module_name
    recipe = recipes[0] if recipes else ""
    en = (
        f"1. Add `<ProjectReference Include=\"{rel}\" />` to your host (e.g. `Smartent.Demo.Web`).\n"
        f"2. Build: `dotnet build {rel}`.\n"
        f"3. Run the site, open **Configuration → Features**, enable **`{feat}`** (and dependencies listed above).\n"
        f"4. Apply setup recipe if needed: `{recipe or 'see Samples folder'}` from **Tools → Recipes**.\n"
        f"5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`."
    )
    cn = (
        f"1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include=\"{rel}\" />`。\n"
        f"2. 构建：`dotnet build {rel}`。\n"
        f"3. 运行站点，在 **配置 → 功能** 中启用 **`{feat}`** 及上表依赖。\n"
        f"4. 需要时从 **工具 → 配方** 执行：`{recipe or '见 Samples 目录'}`。\n"
        f"5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。"
    )
    return en, cn


def config_section(keys: list[str]) -> tuple[str, str]:
    if not keys:
        en = "No dedicated `appsettings` section in this package; configuration is optional or via Orchard settings."
        cn = "本包无独立 `appsettings` 节；可选通过 Orchard 设置项或无需配置。"
        return en, cn
    lines = "\n".join(f"- `OrchardCore:{k}`" for k in keys[:12])
    lines_cn = "\n".join(f"- `OrchardCore:{k}`" for k in keys[:12])
    en = f"Configuration keys (under `OrchardCore`):\n\n{lines}\n\nUse double underscore in environment variables, e.g. `OrchardCore__{keys[0]}__...`."
    cn = f"配置键（位于 `OrchardCore` 节点下）：\n\n{lines_cn}\n\n环境变量使用双下划线，例如 `OrchardCore__{keys[0]}__...`。"
    return en, cn


def fill(template: str, mapping: dict[str, str]) -> str:
    out = template
    for k, v in mapping.items():
        out = out.replace("{" + k + "}", v)
    return out


def thicken_module(module_root: Path) -> bool:
    main = main_csproj(module_root)
    if not main:
        return False
    package_id = main.stem
    project_dir = main.parent
    manifest = read(project_dir / "Manifest.cs")
    if not manifest:
        for m in project_dir.parent.rglob("Manifest.cs"):
            if m.parent.name == package_id or m.parent.name.endswith(".Samples"):
                manifest = read(m)
                break
    features = resolve_feature_ids(project_dir, parse_features(manifest))
    ft_en, ft_cn = feature_table(features)
    keys = find_config_keys(project_dir)
    if module_root.name == "Smartent.Orchard.Hosting.Tenants":
        keys = find_config_keys(module_root)
    recipes = list_recipes(module_root)
    summary = description_from_csproj(main)
    profile = PROFILES.get(module_root.name, {})
    prof_when = profile.get("when", ("Orchard Core extension module in the Smartent demo monorepo.", "Smartent demo 仓库中的 Orchard Core 扩展模块。"))
    prof_admin = profile.get("admin", ("Use Orchard admin and module-specific menus after enabling features.", "启用功能后通过 Orchard 后台及模块菜单使用。"))
    prof_dev = profile.get("dev", ("Extend via DI, handlers, shapes, and optional recipes in the Samples project.", "通过 DI、Handler、Shape 及 Samples 中的 Recipe 扩展。"))
    prof_caut = profile.get(
        "cautions",
        (
            "- Enable only required features per tenant.\n"
            "- Test with `*.Tests` / `*.Tests.UI` before upgrading Orchard Core.",
            "- 每租户仅启用必要 Feature。\n"
            "- 升级 Orchard Core 前先跑 `*.Tests` / `*.Tests.UI`。",
        ),
    )
    qs_en, qs_cn = quick_start(module_root.name, main, features, recipes)
    cfg_en, cfg_cn = config_section(keys)
    related_en = "\n".join(list_child_projects(module_root)) or "- See solution explorer."
    related_cn = related_en.replace("automated/UI tests", "自动化/UI 测试").replace("samples & recipes", "样例与配方").replace("main module", "主模块")
    samples_en = "\n".join(f"- `{r}`" for r in recipes[:10]) if recipes else f"- Optional: enable `{package_id}.Samples` and import its recipes."
    samples_cn = "\n".join(f"- `{r}`" for r in recipes[:10]) if recipes else f"- 可选：启用 `{package_id}.Samples` 并导入其配方。"
    tests_en = (
        f"```powershell\ndotnet build {main.relative_to(ROOT).as_posix()}\n"
        f"dotnet test {module_root.relative_to(ROOT).as_posix()}/*.Tests*.csproj\n```"
    )
    tests_cn = tests_en

    mapping = {
        "ModuleTitle": package_id,
        "PackageId": package_id,
        "RepoPath": module_root.relative_to(ROOT).as_posix(),
        "SummaryEn": summary,
        "SummaryCn": summary,
        "WhenToUseEn": prof_when[0],
        "WhenToUseCn": prof_when[1],
        "QuickStartEn": qs_en,
        "QuickStartCn": qs_cn,
        "FeatureTableEn": ft_en,
        "FeatureTableCn": ft_cn,
        "ConfigurationEn": cfg_en,
        "ConfigurationCn": cfg_cn,
        "AdminUsageEn": prof_admin[0],
        "AdminUsageCn": prof_admin[1],
        "DeveloperUsageEn": prof_dev[0],
        "DeveloperUsageCn": prof_dev[1],
        "ProjectReferenceExample": main.relative_to(ROOT).as_posix(),
        "SamplesEn": samples_en,
        "SamplesCn": samples_cn,
        "CautionsEn": prof_caut[0],
        "CautionsCn": prof_caut[1],
        "TestsEn": tests_en,
        "TestsCn": tests_cn,
        "RelatedProjectsEn": related_en,
        "RelatedProjectsCn": related_cn,
    }

    marker = "<!-- MODULE-DOC-GENERATED -->\n"
    en_body = marker + fill(EN_TPL, mapping)
    cn_body = marker + fill(CN_TPL, mapping)

    def write_docs(target: Path, preserve_long_en: bool) -> None:
        en_path = target / "Readme.md"
        if preserve_long_en and len(read(en_path).strip()) > 150 and marker not in read(en_path):
            text = read(en_path)
            if "Readme-CN.md" not in text[:400]:
                lines = text.splitlines()
                if lines and lines[0].startswith("#"):
                    text = lines[0] + "\n> **中文说明**: [Readme-CN.md](Readme-CN.md)\n\n" + "\n".join(lines[1:])
                en_path.write_text(text, encoding="utf-8", newline="\n")
        else:
            en_path.write_text(en_body, encoding="utf-8", newline="\n")
        (target / "Readme-CN.md").write_text(cn_body, encoding="utf-8", newline="\n")

    preserve_root = module_root == project_dir
    write_docs(module_root, preserve_long_en=not preserve_root)
    if project_dir != module_root:
        write_docs(project_dir, preserve_long_en=False)
    return True


def thicken_hosting_tenant_packages() -> int:
    root = MODULES / "Smartent.Orchard.Hosting.Tenants"
    count = 0
    for csproj in sorted(root.rglob("*.csproj")):
        if ".Tests" in csproj.stem:
            continue
        pkg_dir = csproj.parent
        if pkg_dir == root:
            continue
        manifest = read(pkg_dir / "Manifest.cs")
        features = parse_features(manifest)
        if not features and "Management" not in csproj.stem:
            continue
        ft_en, ft_cn = feature_table(features or [{"Id": csproj.stem, "Name": csproj.stem, "Dependencies": "—"}])
        keys = find_config_keys(pkg_dir)
        cfg_en, cfg_cn = config_section(keys)
        summary = description_from_csproj(csproj)
        mapping = {
            "ModuleTitle": csproj.stem,
            "PackageId": csproj.stem,
            "RepoPath": pkg_dir.relative_to(ROOT).as_posix(),
            "SummaryEn": summary,
            "SummaryCn": summary,
            "WhenToUseEn": "Tenant/hosting automation package; enable only on environments that need this capability.",
            "WhenToUseCn": "租户/托管自动化子模块；仅在需要该能力的环境启用。",
            "QuickStartEn": f"Enable feature `{features[0]['Id'] if features else csproj.stem}` on the host tenant; configure keys under `OrchardCore`.",
            "QuickStartCn": f"在宿主租户启用功能 `{features[0]['Id'] if features else csproj.stem}`；在 `OrchardCore` 下配置相应节。",
            "FeatureTableEn": ft_en,
            "FeatureTableCn": ft_cn,
            "ConfigurationEn": cfg_en,
            "ConfigurationCn": cfg_cn,
            "AdminUsageEn": "Hosting/tenant admin UI varies per package (see source `Startup.cs` and README in solution root).",
            "AdminUsageCn": "后台入口因包而异（见源码 `Startup.cs` 及解决方案根 Readme）。",
            "DeveloperUsageEn": "Reference this csproj from the SaaS/host web app; most packages register tenant management or health endpoints.",
            "DeveloperUsageCn": "从 SaaS/宿主 Web 引用本 csproj；多数包注册租户管理或健康检查端点。",
            "ProjectReferenceExample": csproj.relative_to(ROOT).as_posix(),
            "SamplesEn": "- See `Smartent.Orchard.Hosting.Tenants` solution Readme.",
            "SamplesCn": "- 见 `Smartent.Orchard.Hosting.Tenants` 解决方案根 Readme。",
            "CautionsEn": "- Misconfiguration can lock tenants or block admin login; test in staging.\n- Secrets (storage, AI keys) belong in user secrets or Key Vault, not git.",
            "CautionsCn": "- 配置错误可能导致租户锁定或无法登录后台；请先在预发验证。\n- 存储/密钥等敏感信息勿提交 git。",
            "TestsEn": f"`dotnet test {pkg_dir.relative_to(ROOT).as_posix()}/*.Tests*.csproj`",
            "TestsCn": f"`dotnet test {pkg_dir.relative_to(ROOT).as_posix()}/*.Tests*.csproj`",
            "RelatedProjectsEn": f"- Parent: `src/Modules/Smartent.Orchard.Hosting.Tenants/Readme.md`",
            "RelatedProjectsCn": f"- 上级：`src/Modules/Smartent.Orchard.Hosting.Tenants/Readme-CN.md`",
        }
        (pkg_dir / "Readme.md").write_text(fill(EN_TPL, mapping), encoding="utf-8", newline="\n")
        (pkg_dir / "Readme-CN.md").write_text(fill(CN_TPL, mapping), encoding="utf-8", newline="\n")
        count += 1
    return count


def write_family_docs_redirect(family: Path, main: Path) -> None:
    """When csproj lives in a subfolder, keep family-level Docs-Index pointing at it."""
    if family == main.parent or not main.is_file():
        return
    rel = main.parent.relative_to(family).as_posix()
    en = (
        f"# Documentation index — {family.name}\n\n"
        f"> Main project docs: [{rel}/Docs-Index.md]({rel}/Docs-Index.md)\n\n"
        f"| | |\n|---|---|\n"
        f"| Overview | [Readme.md](Readme.md) · [Readme-CN.md](Readme-CN.md) |\n"
        f"| Topics | [en]({rel}/docs/en/README.md) · [zh-cn]({rel}/docs/zh-cn/README.md) |\n"
    )
    cn = (
        f"# 文档索引 — {family.name}\n\n"
        f"> 主工程文档：[{rel}/Docs-Index-CN.md]({rel}/Docs-Index-CN.md)\n\n"
        f"| | |\n|---|---|\n"
        f"| 总览 | [Readme.md](Readme.md) · [Readme-CN.md](Readme-CN.md) |\n"
        f"| 分主题 | [zh-cn]({rel}/docs/zh-cn/README.md) |\n"
    )
    (family / "Docs-Index.md").write_text(en, encoding="utf-8", newline="\n")
    (family / "Docs-Index-CN.md").write_text(cn, encoding="utf-8", newline="\n")


def main() -> None:
    done = 0
    for name in MODULE_FAMILIES_ORDER:
        root = MODULES / name
        if not root.is_dir():
            continue
        main = main_csproj(root)
        if thicken_module(root):
            done += 1
        if main:
            write_family_docs_redirect(root, main)
    tenants = thicken_hosting_tenant_packages()
    print(f"Thickened {done} module families (ordered) and {tenants} Hosting.Tenants packages.")


if __name__ == "__main__":
    main()