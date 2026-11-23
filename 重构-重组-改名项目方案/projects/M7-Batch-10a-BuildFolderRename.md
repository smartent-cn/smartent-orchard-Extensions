# 子方案：M7 插入批次（Build 目录 Smartent 化）

> 阶段：**M7 / M4 收尾**  
> 状态：**已完成**（2026-11-23）；PackageId 见 M7#11

## 目标

将 `Smartent-src/Build/` 下 8 个 `Lombiq.MSBuild.*` **文件夹**改名为 `Smartent.Build.*`，与 `Smartent.Build.NodeJs` 等并列；**暂不**改 NuGet `PackageId`（仍为 `Lombiq.MSBuild.*`，见 [M7-Batch-11-SdkPackageIdRename.md](M7-Batch-11-SdkPackageIdRename.md)）。

## 映射

| 原目录 | 新目录 |
|--------|--------|
| `Lombiq.MSBuild.Base.Sdk` | `Smartent.Build.Base.Sdk` |
| `Lombiq.MSBuild.LibMan.Targets` | `Smartent.Build.LibMan.Targets` |
| `Lombiq.MSBuild.Library.Sdk` | `Smartent.Build.Library.Sdk` |
| `Lombiq.MSBuild.OrchardCore.Module.Sdk` | `Smartent.Build.OrchardCore.Module.Sdk` |
| `Lombiq.MSBuild.OrchardCore.Theme.Sdk` | `Smartent.Build.OrchardCore.Theme.Sdk` |
| `Lombiq.MSBuild.OrchardCore.Tests.Sdk` | `Smartent.Build.OrchardCore.Tests.Sdk` |
| `Lombiq.MSBuild.OrchardCore.Tests.UI.Sdk` | `Smartent.Build.OrchardCore.Tests.UI.Sdk` |
| `Lombiq.MSBuild.OrchardCore.Tests.UI.Library.Sdk` | `Smartent.Build.OrchardCore.Tests.UI.Library.Sdk` |

`.csproj` 文件名暂保留 `Lombiq.MSBuild.*.csproj`（与 PackageId 一致）。

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1
```