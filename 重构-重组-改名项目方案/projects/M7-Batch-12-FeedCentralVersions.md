# 子方案：M7 批次 #12（feed 与中央版本对齐）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围

| 项 | 说明 |
|----|------|
| `Assert-FeedCorePackVersions.ps1` | `feed-core-pack-versions.ps1` ↔ `NuGetVerify/Directory.Packages.props` |
| `Pack-SmartentLocalFeed.ps1` | pack 前自动 assert |
| `Verify-SmartentLocalFeed.ps1` | 含 `Smartent.Core.AspNet` |
| `docs/releases/M7-FirstNuGet-Release-Draft.md` | 首版发布说明草稿 |
| CI `smartent-local-feed-smoke.yml` | 单一 `Invoke-M7CoreFeedGate.ps1` |

## 验证

```powershell
./scripts/Assert-FeedCorePackVersions.ps1
./scripts/Invoke-M7CoreFeedGate.ps1
```