# 子方案：M7 批次 #20（Build 包垫片 + Core feed 还原 + NuGetVerify 配方）

> 阶段：**M7 / M4**  
> 状态：**已完成**（2026-11-23）

## 范围（10 项）

| # | 项 | 说明 |
|---|-----|------|
| 1 | `Test-NuGetVerifyCorePackageRestore.ps1` | 去掉重复 `--source`，仅用 `NuGetVerify/NuGet.config`（修复 NU1301） |
| 2 | `NuGetVerify/NuGet.config.local.example` | `Smartent.Build.Analyzers.*` → `SmartentLocal` |
| 3 | Npm `build/` 垫片 | `Lombiq.Npm.*` → 转发 `Smartent.Build.Npm.Targets.*`；`LoadCopyVendorsTask` 程序集名 |
| 4 | Npm 根目录垫片 | 新增 `Lombiq.Npm.Targets.props` / `.targets` 兼容包内旧路径 |
| 5 | NodeJs `build/` + 根垫片 | `Lombiq.NodeJs.Extensions.*` 转发 `Smartent.Build.NodeJs.*` |
| 6 | LibMan Sdk 路径 | `SmartentMSBuildLibManTargetsPath` + `Lombiq*` 别名；`LibManIntegration.*` |
| 7 | LibMan 包 | 元数据 + `Lombiq.MSBuild.LibMan.Targets.*` 根垫片并打包 |
| 8 | `Smartent.NuGet.Tests.recipe.json` | feature id 与 `Smartent.Demo.Tests` 对齐（Smartent 模块 id） |
| 9 | Npm `Readme.md` | 验证命令去掉已删 Legacy `src/Utilities` 路径 |
| 10 | 门禁 | `Invoke-M7CoreFeedGate.ps1 -SkipPack` + `Smartent.Orchard.sln` Release |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack
dotnet build Smartent-src/Smartent.Orchard.sln -c Release
```

## 下一批建议

→ **M7 批次 #21**（`M7-Batch-21-Analyzers-NuGetVerify-Recipes.md`）。