# M6 待发布 PackageId 扫描与 Lombiq 例外清单

> 对应 [阶段检查表.md](阶段检查表.md) M6：`无待发布 PackageId 含 Lombiq.`（已文档化例外）

最后扫描：2026-11-22（本批次 M4#12 / M7#2）

## Smartent-src 可发布包

`Smartent-src/**` 下显式 `PackageId` 均为 `Smartent.*`（ Orchard 模块/主题/Core/Platform/Build 工具链）。

## 仍使用 `Lombiq.*` PackageId（已登记例外）

| PackageId / 路径 | 原因 | 目标（草案） |
|------------------|------|-------------|
| `Lombiq.MSBuild.Base.Sdk` 及 `Lombiq.MSBuild.*.Sdk` | MSBuild Sdk 仍在 `src/Utilities/Lombiq.MSBuild.Targets`；**Base.Sdk 源码已迁至** `Smartent-src/Build/Lombiq.MSBuild.Base.Sdk` | `Smartent.Build.*.Sdk`（M7 全仓 Sdk= 切换后） |
| `Lombiq.MSBuild.LibMan.Targets` | 未迁 Build 层 | `Smartent.Build.LibMan.Targets` |
| `Lombiq.Analyzers` / `Lombiq.Analyzers.OrchardCore` / `Lombiq.Analyzers.PowerShell` | 开发期分析器；NuGet 上仍 Lombiq 品牌 | `Smartent.Build.Analyzers*`（可选，M1/M4） |
| `Lombiq.HelpfulLibraries.OrchardCore` | 仅 **NuGetVerify 独立检出** + 旧 Module.Sdk 2.1.1 还原 | 移除（新 Sdk + Smartent 包上源后） |

## 非发布 / 不纳入扫描

- `NuGetVerify` 宿主工程（`Smartent.NuGet.*`）：不发布 NuGet。
- Legacy `src/Modules`、`src/Themes` 等归档路径：迁一删一完成前可能仍存在旧 ID，不作为 Smartent 产品发布面。
- Orchard Core 官方包、`Meziantou.Analyzer` 等第三方。

## 复检命令

```powershell
# 可发布树（Smartent-src）中不应出现待发布 Lombiq PackageId
rg '<PackageId>Lombiq\.' Smartent-src --glob '*.csproj'

# 全仓待发布 Lombiq（含 MSBuild Sdk）
rg '<PackageId>Lombiq\.' --glob '*.csproj'
```

复检结果（2026-11-22）：`Smartent-src` 无匹配；`Lombiq.MSBuild.*` 仅在 `src/Utilities/Lombiq.MSBuild.Targets`。