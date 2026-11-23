# 子方案：M5 批次 #4（BuildVersion + Tenants + Demo.Samples + Base/Media 主题）

> 阶段：**M5**  
> 状态：**已迁入 src**（2026-11-22）

## 范围

| Legacy | Smartent-src |
|--------|----------------|
| `Lombiq.Hosting.BuildVersionDisplay` (+ Tests.UI) | `src/Modules/Smartent.Orchard.Hosting.BuildVersion/` |
| `Lombiq.Hosting.Tenants`（多 csproj） | `src/Modules/Smartent.Orchard.Hosting.Tenants/` |
| `Lombiq.OSOCE.Samples` | `src/Demo/Smartent.Demo.Samples/` |
| `Lombiq.BaseTheme`（Core/Native/Samples 等） | `src/Themes/Smartent.Orchard.Theme.Base/` |
| `Lombiq.Hosting.MediaTheme`（含 Bridge、Tests.Theme） | `src/Themes/Smartent.Orchard.Theme.Media/` |

## Feature Id（破坏性，示例）

| 原前缀 | 新前缀 |
|--------|--------|
| `Lombiq.Hosting.BuildVersionDisplay` | `Smartent.Orchard.Hosting.BuildVersion` |
| `Lombiq.Hosting.Tenants.*` | `Smartent.Orchard.Hosting.Tenants.*`（子功能名保留后缀） |
| `Lombiq.OSOCE.Samples` | `Smartent.Demo.Samples` |
| `Lombiq.BaseTheme.*` | `Smartent.Orchard.Theme.Base.*` |
| `Lombiq.Hosting.MediaTheme` / `*.Bridge` 等 | `Smartent.Orchard.Theme.Media.*` |

已同步：`Smartent.Demo.Web` ProjectReference / Recipe、`test/Smartent.Test.Acceptance`、`Smartent.Orchard.sln` / `slnx`、`HostingDefaultsOrchardCoreBuilderExtensions`（BuildVersion 功能串）。

## 验证

```powershell
$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet build Smartent.Orchard.sln -c Release
```

Release 构建：**0 错误**（2026-11-22）。

## 迁一删一

Legacy 目录仅留 `Readme.md` 指针：

- `src/Modules/Lombiq.Hosting.BuildVersionDisplay/`
- `src/Modules/Lombiq.Hosting.Tenants/`
- `src/Modules/Lombiq.OSOCE.Samples/`
- `src/Themes/Lombiq.BaseTheme/`
- `src/Themes/Lombiq.Hosting.MediaTheme/`

## 未决

- 各模块 `Manifest.cs` 中面向用户的 **Name/Website** 仍部分引用 Lombiq 上游仓库（NuGet 元数据渐进更新）
- BaseTheme Native Samples 中 `node_modules` 深层路径在 Windows 上仍可能导致局部清理脚本失败（与 VueJs 同类）
- Layer 6：`Smartent.Demo.Web`、验收测试工程仍为 legacy 路径/命名