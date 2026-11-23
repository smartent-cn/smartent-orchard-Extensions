# 子方案：M7 批次 #17（发布就绪与文档收尾）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围

| # | 项 | 说明 |
|---|-----|------|
| 1 | `scripts/README.md` | 含 `Seed-LocalFeedSdkToNuGetCache.ps1`、`Assert-*`、`Export-*` |
| 2 | `NuGetVerify/Readme.md` | `Smartent.Build.*` Sdk **2.1.1**、`Invoke-M7CoreFeedGate` |
| 3 | `M7-Batch-10-GiteePublish.md` | Sdk 改名已完成；未决仅剩 Gitee token |
| 4 | `阶段检查表.md` | M7：本地 `SmartentLocal`、core assert |
| 5 | `项目清单.md` | M7 批次 #10a–#16 已推送 |
| 6 | `docs/releases/M7-FirstNuGet-Release-Draft.md` | 与 `feed-manifest` / `List-SmartentPackableProjects` 对齐 |
| 7 | `NuGet.config` / `NuGetVerify/NuGet.config` | `SmartentLocal` 已启用（开发机） |
| 8 | `NuGetVerify/global.json` | `msbuild-sdks` 2.1.1 版本钉扎 |
| 9 | CI `smartent-local-feed-smoke.yml` | 保持 `Invoke-M7CoreFeedGate` |
| 10 | 门禁 | `./scripts/Invoke-M7CoreFeedGate.ps1` 绿 |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1
./scripts/Export-FeedManifestSummary.ps1
```

## 下一批建议

- **M7#13**：本地 `-Full` pack + 全 `Smartent.NuGet.sln`（耗时长，手动/夜间）
- **M7#10**：Gitee Packages 推送与 `Build-NuGetVerify-WithLocalFeed.ps1 -SkipPack`