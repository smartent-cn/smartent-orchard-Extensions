# 子方案：M6 批次 #1（Demo.Web + 测试工具链）

> 阶段：**M6**  
> 状态：**已迁入 Smartent-src**（2026-11-22）

## 范围

| Legacy | Smartent-src |
|--------|----------------|
| `Lombiq.OSOCE.Web` | `Smartent-src/Demo/Smartent.Demo.Web/` |
| `Lombiq.OSOCE.Tests.UI` | `Smartent-src/Test/Smartent.Test.Acceptance/` |
| `Lombiq.UITestingToolbox` / `Lombiq.Tests.UI.*` | `Smartent-src/Test/Smartent.Test.UI/` |
| `Lombiq.Tests` | `Smartent-src/Test/Smartent.Test.Unit/` |

## 破坏性变更（摘要）

| 原 | 新 |
|----|-----|
| `Lombiq.OSOCE.Web` | `Smartent.Demo.Web`（程序集/宿主） |
| `Lombiq.OSOCE.Tests.UI` | `Smartent.Test.Acceptance` |
| `Lombiq.Tests.UI` | `Smartent.Test.UI` |
| `Lombiq.Tests` | `Smartent.Test.Unit` |

Recipe Id（如 `Lombiq.OSOCE.Tests`）与部分文件名 **暂保留**，避免打断现有 UI 测试；Feature Id 已 Smartent 化（如 `Smartent.Test.UI.AdminTheme`）。

已同步：`Smartent.Orchard.sln` / `slnx`、MSBuild `OrchardCore.Tests.UI*.Sdk` 内 `ProjectReference`、全仓 `PackageReference` 草案名。

## 验证

```powershell
$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet build Smartent.Orchard.sln -c Release
```

Release 构建：**0 错误**（2026-11-22）。

## 迁一删一

Legacy 指针：

- `src/Lombiq.OSOCE.Web/`
- `test/Lombiq.OSOCE.Tests.UI/`
- `test/Lombiq.UITestingToolbox/`
- `test/Lombiq.Tests/`

## 未决

- `NuGetVerify` 独立还原 Smartent 包（见 [M7-Batch-LocalNuGetFeed.md](M7-Batch-LocalNuGetFeed.md)）
- 对外 NuGet：`PackageVersionLombiqTests*` 属性名渐进重命名
- 全量 UI 测试执行（非 sln 构建门禁）