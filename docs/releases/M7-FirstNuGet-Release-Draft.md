# M7 首版 NuGet 发布说明（草案）

> 状态：**草稿**；正式发布前与 `artifacts/smartent-nuget-local/feed-manifest.txt` 及 Gitee Packages 对齐。

## 版本策略

- 建议首版 **`1.0.0`** 或延续当前 csproj 版本（Platform 等见 `NuGetVerify/Directory.Packages.props`）。
- **core 本地 feed** 版本须与中央包管理一致：`scripts/Assert-FeedCorePackVersions.ps1`。

## Core feed 包（`Pack-SmartentLocalFeed.ps1` 默认）

见 `scripts/feed-core-pack-versions.ps1` 与 `Verify-SmartentLocalFeed.ps1` 必备列表。

全量可发布面粗筛：`./scripts/List-SmartentPackableProjects.ps1`

## 发布前清单

- [x] `Invoke-M7CoreFeedGate.ps1` 绿（本地；CI 见 `smartent-local-feed-smoke.yml`）
- [x] `Export-FeedManifestSummary.ps1` 与本地 feed 对齐（示例：`Total: 123` · `Smartent.*: 113` · `Lombiq.*: 10` — 以当前 `feed-manifest.txt` 为准）
- [ ] Gitee `NuGet.config` 源已启用（[M7-Batch-15](../../重构-重组-改名项目方案/projects/M7-Batch-15-GiteeNuGetConfig.md)；示例 [NuGet.config.gitee.example](NuGet.config.gitee.example)）
- [x] `Build-NuGetVerify-WithLocalFeed.ps1` 全 `Smartent.NuGet.sln` Release 构建绿（本地 `-SkipPack` + supplemental gaps）

## 全量 NuGetVerify

`Smartent.NuGet.Web` Recipe 引用的 **全部** `Smartent.*` 模块须通过：

```powershell
./scripts/Pack-SmartentLocalFeed.ps1 -Full
./scripts/Build-NuGetVerify-WithLocalFeed.ps1 -SkipPack
./scripts/Export-FeedManifestSummary.ps1
```

## Gitee 推送（M7#10）

```powershell
$env:GITEE_NUGET_SOURCE_URL = 'https://gitee.com/api/v5/packages/<owner>/<repo>/nuget/index.json'  # 以实称为准
$env:GITEE_NUGET_API_KEY = '<token>'
./scripts/Publish-SmartentFeedToGitee.ps1 -WhatIf
./scripts/Publish-SmartentFeedToGitee.ps1
```

## 仍保留 Lombiq PackageId（首版可并存）

| PackageId | 计划 |
|-----------|------|
| ~~`Lombiq.MSBuild.*` Sdk~~ | 已 **Smartent.Build.***（2.1.1）；见 M7#11 |
| `Smartent.Build.Analyzers.*` | 可选 `Smartent.Build.Analyzers.*` |
| ~~`Lombiq.HelpfulLibraries.OrchardCore`~~ | **已移除**；NuGetVerify 使用 `Smartent.Orchard.Platform` |

## License / 版权

- 保留 Lombiq 原作者与许可证声明；Smartent 增补版权页（签收前完成，见 [阶段检查表.md](../../重构-重组-改名项目方案/阶段检查表.md) M7）。