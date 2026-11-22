# 子方案：M5 批次 #2（ContentEditors + JsonEditor + EmailClient + Privacy + AuditTrail）

> 阶段：**M5**  
> 状态：**已迁入 Smartent-src**（2026-11-22）

## 范围

| Legacy | Smartent-src |
|--------|----------------|
| `Lombiq.ContentEditors` (+ Samples, Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.ContentEditors/` |
| `Lombiq.JsonEditor` (+ Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.JsonEditor/` |
| `Lombiq.EmailClient` (+ Samples, Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.EmailClient/` |
| `Lombiq.Privacy` (+ Samples, Tests.UI) | `Smartent-src/Modules/Smartent.Orchard.Privacy/` |
| `Lombiq.AuditTrailExtensions` | `Smartent-src/Modules/Smartent.Orchard.AuditTrail/` |

## Feature Id（破坏性）

| 原前缀 | 新前缀 |
|--------|--------|
| `Lombiq.ContentEditors` | `Smartent.Orchard.ContentEditors` |
| `Lombiq.JsonEditor` | `Smartent.Orchard.JsonEditor` |
| `Lombiq.EmailClient` | `Smartent.Orchard.EmailClient` |
| `Lombiq.Privacy` | `Smartent.Orchard.Privacy` |
| `Lombiq.AuditTrailExtensions` | `Smartent.Orchard.AuditTrail` |

子功能保持 `.<Name>` 后缀（如 `Smartent.Orchard.JsonEditor.ContentEditor`、`Smartent.Orchard.Privacy.ConsentBanner`）。

已同步：`Lombiq.OSOCE.Web` Recipe、`Lombiq.OSOCE.Tests.UI` 项目引用与 `using`、`Smartent.Orchard.sln` / `slnx`、`Lombiq.Hosting.Azure.ApplicationInsights.Tests.UI` 对 Privacy Tests.UI 的引用。

## 验证

```powershell
$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet build Smartent.Orchard.sln -c Release
```

本批次模块无独立 `*.Tests` 单元测试项目（仅有 `*.Tests.UI` 扩展库）。

## 迁一删一

Legacy 目录仅留 `Readme.md` 指针（`src/Modules/Lombiq.{ContentEditors,JsonEditor,EmailClient,Privacy,AuditTrailExtensions}/`）。

## 未决

- `NuGetTest/` 仍为 Lombiq 包名占位（独立 NuGet 管线未 Smartent 发包）
- `ContentEditors` 仍 `ProjectReference` 至 legacy `Lombiq.VueJs.Resources`（VueJs 未 Smartent 化前保留）