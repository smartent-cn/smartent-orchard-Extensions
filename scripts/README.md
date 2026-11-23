# 根目录脚本 | Repository scripts

| 脚本 | 用途 |
|------|------|
| [Pack-SmartentLocalFeed.ps1](Pack-SmartentLocalFeed.ps1) | Pack core 工程到 `artifacts/smartent-nuget-local/` 并默认 **Verify**（`-Full` / `-SkipVerify` / `-WhatIf`） |
| [Verify-SmartentLocalFeed.ps1](Verify-SmartentLocalFeed.ps1) | 校验 core feed 必备 nupkg，写出 `feed-manifest.txt` |
| [Build-NuGetVerify-WithLocalFeed.ps1](Build-NuGetVerify-WithLocalFeed.ps1) | `-Full` pack + supplemental gaps + `Directory.Packages.local.props` + 全 sln；`-SkipPack` 模拟远程已发布 |
| [Align-NuGetVerifyVersionsToLocalFeed.ps1](Align-NuGetVerifyVersionsToLocalFeed.ps1) | 由 feed-manifest 生成 `NuGetVerify/Directory.Packages.local.props`（仅 `Smartent.*`） |
| [Pack-NuGetVerifySupplementalGaps.ps1](Pack-NuGetVerifySupplementalGaps.ps1) | 按 Web/Tests.UI 引用差集增量 pack（含非 sln 工程） |
| [feed-full-verify-supplemental.ps1](feed-full-verify-supplemental.ps1) | `-Full` 后固定 supplemental 列表（Marketing、VueJs.Resources 等） |
| [Test-NuGetVerifyCorePackageRestore.ps1](Test-NuGetVerifyCorePackageRestore.ps1) | core feed + `ForceStandaloneNuGetVerify` 还原 Tests/Module/Theme |
| [Invoke-M7CoreFeedGate.ps1](Invoke-M7CoreFeedGate.ps1) | 上述 + Monorepo sln 构建 + `Smartent.Build.Targets.Tests`（`-SkipPack` / `-WhatIf`） |
| [Invoke-M7FullNuGetVerifyGate.ps1](Invoke-M7FullNuGetVerifyGate.ps1) | Core gate + 全 `Smartent.NuGet.sln`（`-SkipPack` 需 `NuGet.config.local` + 已 pack feed） |
| [Assert-FeedCorePackVersions.ps1](Assert-FeedCorePackVersions.ps1) | 校验 core pack 版本与 `NuGetVerify/Directory.Packages.props` |
| [List-SmartentPackableProjects.ps1](List-SmartentPackableProjects.ps1) | 列出 `src` 中带 `PackageId` 的工程 |
| [Export-FeedManifestSummary.ps1](Export-FeedManifestSummary.ps1) | 汇总 `feed-manifest.txt`（Smartent/Lombiq 计数） |
| [Seed-LocalFeedSdkToNuGetCache.ps1](Seed-LocalFeedSdkToNuGetCache.ps1) | 可选：将 feed 内 **MSBuildSdk** nupkg 解压到本地包缓存（纯 Sdk 还原调试） |
| [Publish-SmartentFeedToGitee.ps1](Publish-SmartentFeedToGitee.ps1) | 环境变量 `GITEE_NUGET_SOURCE_URL` / `GITEE_NUGET_API_KEY` 推送本地 feed；`-WhatIf` 列举 |

**English**: PowerShell helpers for M7 local NuGet feed smoke tests. Core pack versions live in `feed-core-pack-versions.ps1` (sync with `NuGetVerify/Directory.Packages.props`). Copy `NuGet.config.local.example` → `NuGet.config.local` before full sln build. After `-Full` pack, `Align-NuGetVerifyVersionsToLocalFeed.ps1` writes gitignored `Directory.Packages.local.props` so restore versions match the feed.