# M6 待发布 PackageId 扫描与 Lombiq 例外清单

> 对应 [阶段检查表.md](阶段检查表.md) M6：`无待发布 PackageId 含 Lombiq.`（已文档化例外）

最后扫描：2026-11-24（NuGetVerify 中央版本已无 Lombiq 平台/测试包；仅 `Lombiq.Analyzers.OrchardCore`）

## Smartent-src 可发布包

`Smartent-src/**` 下显式 `PackageId` 均为 `Smartent.*`（ Orchard 模块/主题/Core/Platform/Build 工具链）。

## 仍使用 `Lombiq.*` PackageId（已登记例外）

| PackageId / 路径 | 原因 | 目标（草案） |
|------------------|------|-------------|
| ~~`Lombiq.MSBuild.*` Sdk / LibMan~~ | **已收口** | `Smartent.Build.*`（M7#11，版本 **2.1.1** 本地 feed） |
| `Lombiq.Analyzers` / `Lombiq.Analyzers.OrchardCore` / `Lombiq.Analyzers.PowerShell` | 开发期分析器；NuGet 上仍 Lombiq 品牌 | `Smartent.Build.Analyzers*`（可选，M1/M4） |
| ~~`Lombiq.HelpfulLibraries.OrchardCore`~~ | **已移除** 中央版本 | `Smartent.Orchard.Platform` @ 本地 feed / Gitee |
| ~~`Lombiq.Tests`~~ | **已移除** 中央版本 | `Smartent.Build.OrchardCore.Tests.Sdk` → `Smartent.Test.Unit` |

## 非发布 / 不纳入扫描

- `NuGetVerify` 宿主工程（`Smartent.NuGet.*`）：不发布 NuGet。
- Legacy `src/`：Modules/Themes/test 指针已删；`Utilities`/`Libraries` 仅 Readme + MSBuild shim，**无**待发布 `.csproj`。
- Orchard Core 官方包、`Meziantou.Analyzer` 等第三方。

## 复检命令

```powershell
# 可发布树（Smartent-src）中不应出现待发布 Lombiq PackageId
rg '<PackageId>Lombiq\.' Smartent-src --glob '*.csproj'

# 全仓待发布 Lombiq（含 MSBuild Sdk）
rg '<PackageId>Lombiq\.' --glob '*.csproj'
```

复检结果（2026-11-24）：`rg '<PackageId>Lombiq\.' --glob '*.csproj'` **0 匹配**；`NuGetVerify/Directory.Packages.props` 中 Lombiq 仅 **分析器** 一行。