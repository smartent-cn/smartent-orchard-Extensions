# 根目录脚本 | Repository scripts

| 脚本 | 用途 |
|------|------|
| [Pack-SmartentLocalFeed.ps1](Pack-SmartentLocalFeed.ps1) | Pack core 工程到 `artifacts/smartent-nuget-local/` 并默认 **Verify**（`-Full` / `-SkipVerify`） |
| [Verify-SmartentLocalFeed.ps1](Verify-SmartentLocalFeed.ps1) | 校验 core feed 必备 nupkg，写出 `feed-manifest.txt` |
| [Build-NuGetVerify-WithLocalFeed.ps1](Build-NuGetVerify-WithLocalFeed.ps1) | 默认 `-Full` pack + `NuGet.config.local` 构建全 sln；`-CorePack` / `-SkipPack` |
| [Test-NuGetVerifyCorePackageRestore.ps1](Test-NuGetVerifyCorePackageRestore.ps1) | core feed + `ForceStandaloneNuGetVerify` 还原 Tests/Module/Theme |
| [Invoke-M7CoreFeedGate.ps1](Invoke-M7CoreFeedGate.ps1) | 上述 + `Smartent.NuGet.Monorepo.sln` 构建（M7 推荐本地门禁） |

**English**: PowerShell helpers for M7 local NuGet feed smoke tests. Core pack versions live in `feed-core-pack-versions.ps1` (sync with `NuGetVerify/Directory.Packages.props`). Copy `NuGet.config.local.example` → `NuGet.config.local` before full sln build.