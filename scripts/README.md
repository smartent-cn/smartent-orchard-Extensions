# 根目录脚本 | Repository scripts

| 脚本 | 用途 |
|------|------|
| [Pack-SmartentLocalFeed.ps1](Pack-SmartentLocalFeed.ps1) | Pack core 工程到 `artifacts/smartent-nuget-local/` 并默认 **Verify**（`-Full` / `-SkipVerify` / `-WhatIf`） |
| [Verify-SmartentLocalFeed.ps1](Verify-SmartentLocalFeed.ps1) | 校验 core feed 必备 nupkg，写出 `feed-manifest.txt` |
| [Build-NuGetVerify-WithLocalFeed.ps1](Build-NuGetVerify-WithLocalFeed.ps1) | 默认 `-Full` pack + `NuGet.config.local` 构建全 sln；`-CorePack` / `-SkipPack` |
| [Test-NuGetVerifyCorePackageRestore.ps1](Test-NuGetVerifyCorePackageRestore.ps1) | core feed + `ForceStandaloneNuGetVerify` 还原 Tests/Module/Theme |
| [Invoke-M7CoreFeedGate.ps1](Invoke-M7CoreFeedGate.ps1) | 上述 + Monorepo sln 构建（`-SkipPack` / `-WhatIf`） |
| [Assert-FeedCorePackVersions.ps1](Assert-FeedCorePackVersions.ps1) | 校验 core pack 版本与 `NuGetVerify/Directory.Packages.props` |
| [List-SmartentPackableProjects.ps1](List-SmartentPackableProjects.ps1) | 列出 `Smartent-src` 中带 `PackageId` 的工程 |
| [Export-FeedManifestSummary.ps1](Export-FeedManifestSummary.ps1) | 汇总 `feed-manifest.txt`（Smartent/Lombiq 计数） |
| [Seed-LocalFeedSdkToNuGetCache.ps1](Seed-LocalFeedSdkToNuGetCache.ps1) | 可选：将 feed 内 **MSBuildSdk** nupkg 解压到本地包缓存（纯 Sdk 还原调试） |

**English**: PowerShell helpers for M7 local NuGet feed smoke tests. Core pack versions live in `feed-core-pack-versions.ps1` (sync with `NuGetVerify/Directory.Packages.props`). Copy `NuGet.config.local.example` → `NuGet.config.local` before full sln build.