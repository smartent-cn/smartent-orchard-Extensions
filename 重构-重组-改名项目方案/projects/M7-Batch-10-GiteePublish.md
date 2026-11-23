# 子方案：M7 批次 #10（远程源与发布清单）

> 阶段：**M7**  
> 状态：**占位**（2026-11-23）

## 范围

| 项 | 说明 |
|----|------|
| 根 `NuGet.config` / Gitee Packages URL | 定稿后取消注释 `Smartent` 源与 mapping |
| `Build-NuGetVerify-WithLocalFeed.ps1` | 远程源版：仅 `-SkipPack` + 已发布包 |
| 发布说明 | `1.0.0` 首包清单、License、版权页 |
| `dotnet pack` | 与 `feed-manifest` / 产品清单对齐 |

## 验证

```powershell
# 远程源就绪后
./scripts/Build-NuGetVerify-WithLocalFeed.ps1 -SkipPack
```

本地发布前请先绿：`./scripts/Invoke-M7CoreFeedGate.ps1`

## 未决

- Gitee API token / CI secrets
- `Lombiq.MSBuild.*` PackageId → `Smartent.Build.*` 改名批次（可与发布并行规划）