# 子方案：M7 批次 #15（Gitee Packages 配置模板）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围

| 项 | 说明 |
|----|------|
| 根 `NuGet.config` | 注释示例：`Smartent` 源 + `SmartentLocal` + `packageSourceMapping` |
| `NuGetVerify/NuGet.config` | 与本地 feed 示例一致 |
| `M7-Batch-10-GiteePublish.md` | 远程 `-SkipPack` 流程 |

## 启用步骤（定稿 URL 后）

1. 在 Gitee 创建 NuGet 源，获取带 token 的 v3 URL（勿提交 token 到仓库）。
2. 取消注释根 `NuGet.config` 中 `Smartent` / `SmartentLocal` 与 `<packageSourceMapping>`。
3. `dotnet nuget add source ...` 或在 CI secret 中配置。
4. `./scripts/Build-NuGetVerify-WithLocalFeed.ps1 -SkipPack`

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1
./scripts/Export-FeedManifestSummary.ps1
```