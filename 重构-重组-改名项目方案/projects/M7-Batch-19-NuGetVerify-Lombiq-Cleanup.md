# 子方案：M7 批次 #19（NuGetVerify Lombiq 中央版本收口）

> 阶段：**M7 / M6**  
> 状态：**已完成**（2026-11-24）

## 范围（10 项）

| # | 项 | 说明 |
|---|-----|------|
| 1 | `NuGetVerify/Directory.Packages.props` | 移除 `Lombiq.Tests` 中央版本（#18 已移除 `HelpfulLibraries.OrchardCore`） |
| 2 | `NuGetVerify/NuGet.config.local.example` | mapping 仅 `Smartent.*` / `Smartent.Build.*` |
| 3 | 根 `NuGet.config` | 注释 mapping 去掉 `Lombiq.MSBuild.*` |
| 4 | `M6-PackageId-Exceptions.md` | 仅分析器例外 |
| 5 | `M7-Batch-9` / `M7-Batch-NuGetTest-PackageIds` | 文档同步 |
| 6 | `NuGetVerify/Readme.md` | Smartent.Test.Unit 还原说明 |
| 7 | Legacy `UsingMSBuildSdks.md` | 指针 → `src/Build/docs` |
| 8 | `src/Build/docs/UsingMSBuildSdks.md` | 去掉 HelpfulLibraries Legacy 路径说明 |
| 9 | `scripts/README.md` | Full gate 前置条件 |
| 10 | 门禁 | `Invoke-M7CoreFeedGate.ps1 -SkipPack` |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack
# 全 sln（已有 feed + NuGet.config.local）：
./scripts/Invoke-M7FullNuGetVerifyGate.ps1 -SkipPack
```

## 下一批建议

→ **M7 批次 #20**（`M7-Batch-20-BuildTargets-FeedGate.md`）：Npm/NodeJs/LibMan 包垫片、NU1301 修复、NuGetVerify Tests 配方 feature id。