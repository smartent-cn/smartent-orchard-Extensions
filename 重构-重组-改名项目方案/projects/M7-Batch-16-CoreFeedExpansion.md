# 子方案：M7 批次 #16（core feed 扩展 LibMan）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围

| 项 | 说明 |
|----|------|
| `feed-core-pack-versions.ps1` | 增加 `Lombiq.MSBuild.LibMan.Targets` core pack |
| `Verify-SmartentLocalFeed.ps1` | 必备列表含 LibMan |
| `Export-FeedManifestSummary.ps1` | manifest 按 Smartent/Lombiq 前缀统计 |
| `Invoke-M7CoreFeedGate.ps1` | `-WhatIf` 仅 assert |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1
./scripts/Export-FeedManifestSummary.ps1
```