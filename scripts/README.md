# 根目录脚本 | Repository scripts

| 脚本 | 用途 |
|------|------|
| [Pack-SmartentLocalFeed.ps1](Pack-SmartentLocalFeed.ps1) | Pack core 工程到 `artifacts/smartent-nuget-local/` 并默认 **Verify**（`-Full` / `-SkipVerify`） |
| [Verify-SmartentLocalFeed.ps1](Verify-SmartentLocalFeed.ps1) | 校验 core feed 必备 nupkg，写出 `feed-manifest.txt` |
| [Build-NuGetVerify-WithLocalFeed.ps1](Build-NuGetVerify-WithLocalFeed.ps1) | 默认 `-Full` pack + `NuGet.config.local` 构建全 sln；`-CorePack` / `-SkipPack` |

**English**: PowerShell helpers for M7 local NuGet feed smoke tests. Copy `NuGetVerify/NuGet.config.local.example` → `NuGet.config.local` before the build script. CI uses `NuGetVerify/Smartent.NuGet.Monorepo.sln` without a Smartent package feed.