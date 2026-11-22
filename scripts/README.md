# 根目录脚本 | Repository scripts

| 脚本 | 用途 |
|------|------|
| [Pack-SmartentLocalFeed.ps1](Pack-SmartentLocalFeed.ps1) | Pack 可发布工程到 `artifacts/smartent-nuget-local/`（`-Full` = 全 `Smartent.Orchard.sln`） |
| [Build-NuGetVerify-WithLocalFeed.ps1](Build-NuGetVerify-WithLocalFeed.ps1) | 可选 `-Full` pack，再用 `NuGetVerify/NuGet.config.local` 还原/构建 `Smartent.NuGet.sln` |

**English**: PowerShell helpers for M7 local NuGet feed smoke tests. Copy `NuGetVerify/NuGet.config.local.example` → `NuGet.config.local` before the build script. CI uses `NuGetVerify/Smartent.NuGet.Monorepo.sln` without a Smartent package feed.