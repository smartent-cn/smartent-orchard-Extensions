# 子方案：M7 批次 #21（分析器 MSBuild 目标 + NuGetVerify 配方/命令）

> 阶段：**M7 / tools / NuGetVerify**  
> 状态：**已完成**（2026-11-23）

## 范围（10 项）

| # | 项 | 说明 |
|---|-----|------|
| 1 | `Smartent.Build.Analyzers/Build.props` | 主目标 `SmartentNetAnalyzers`；`LombiqNetAnalyzers` 为 DependsOnTargets 别名 |
| 2 | 分析器测试方案 `.csproj` | `AfterTargets` / 说明改为 `SmartentNetAnalyzers` |
| 3 | `UsingAnalyzersDuringCommandLineBuilds.md` | 文档示例目标名 Smartent（保留 Lombiq 说明） |
| 4 | `Smartent.GitHub.Actions` `Build-DotNetSolutionOrProject.ps1` | CI 调用 `SmartentNetAnalyzers` |
| 5 | `NuGetVerify/commands.json` | `Update-SmartentNuGetPackages.ps1` + `Update-LombiqNuGetPackages.ps1` 转发垫片 |
| 6 | `Smartent.NuGet.Web.recipe.json` | Media Theme feature id → `Smartent.Orchard.Theme.Media.*` |
| 7 | `Smartent.NuGet.BaseTheme.recipe.json` + `Smartent.Demo.BaseTheme.recipe.json` | `Smartent.Orchard.Theme.Base.Samples` |
| 8 | NuGet 测试配方文案 | `Smartent.NuGet.Tests` / `BasicOrchardFeaturesTests` displayName；`Smartent.NuGet.Web/Readme.md` |
| 9 | `docs/migration/Recipe-Id-Rename.md` | NuGetVerify 配方与主题 feature id 对照 |
| 10 | 门禁 | `Invoke-M7CoreFeedGate.ps1 -SkipPack` + `Smartent.Orchard.sln` Release |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack
dotnet build Smartent.Orchard.sln -c Release
```

## 下一批建议

→ **M7 批次 #22**（`M7-Batch-22-Marketing-Config-Docs-Ci.md`）。