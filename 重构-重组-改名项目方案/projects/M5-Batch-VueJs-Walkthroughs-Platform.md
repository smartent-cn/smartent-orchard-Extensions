# 子方案：M5 批次 #3（VueJs + Walkthroughs + LoginAsAnybody + Marketing + Hosting.ApplicationInsights）

> 阶段：**M5**  
> 状态：**已迁入 src**（2026-11-22）

## 范围

| Legacy | Smartent-src |
|--------|----------------|
| `Lombiq.VueJs` (+ Resources, Samples, Tests.UI) | `src/Modules/Smartent.Orchard.VueJs/` |
| `Lombiq.Walkthroughs` (+ Tests.UI) | `src/Modules/Smartent.Orchard.Walkthroughs/` |
| `Lombiq.LoginAsAnybody` (+ Tests.UI) | `src/Modules/Smartent.Orchard.LoginAsAnybody/` |
| `Lombiq.Marketing` (+ Pirsch, UrlShortener, Tests.UI) | `src/Modules/Smartent.Orchard.Marketing/` |
| `Lombiq.Hosting.Azure.ApplicationInsights` (+ Tests.UI) | `src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/` |

## Feature Id（破坏性）

| 原前缀 | 新前缀 |
|--------|--------|
| `Lombiq.VueJs` | `Smartent.Orchard.VueJs` |
| `Lombiq.VueJs.Resources` | `Smartent.Orchard.VueJs.Resources` |
| `Lombiq.VueJs.Samples` | `Smartent.Orchard.VueJs.Samples` |
| `Lombiq.Walkthroughs` | `Smartent.Orchard.Walkthroughs` |
| `Lombiq.LoginAsAnybody` | `Smartent.Orchard.LoginAsAnybody` |
| `Lombiq.Marketing` | `Smartent.Orchard.Marketing` |
| `Lombiq.Marketing.Pirsch` | `Smartent.Orchard.Marketing.Pirsch` |
| `Lombiq.Marketing.UrlShortener` | `Smartent.Orchard.Marketing.UrlShortener` |
| `Lombiq.Hosting.Azure.ApplicationInsights` | `Smartent.Orchard.Hosting.ApplicationInsights` |

已同步：`Smartent.Demo.Web` / Recipe、`test/Smartent.Test.Acceptance`、`Smartent.Orchard.ContentEditors` → `VueJs.Resources`、`Smartent.Orchard.sln` / `slnx`。

## 验证

```powershell
$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet build Smartent.Orchard.sln -c Release
```

## 迁一删一

Legacy 目录仅留 `Readme.md` 指针。`Lombiq.VueJs` 若仍含未跟踪的 `node_modules/`，需本地删除后再移除目录。

## 未决

- `NuGetVerify/` 仍为 Lombiq 包名占位
- VueJs 前端 `pnpm build` 全 sln 门禁（与 M4 记录一致）