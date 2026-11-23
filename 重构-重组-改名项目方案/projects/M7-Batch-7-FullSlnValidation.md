# 子方案：M7 批次 #7（全 sln 与 feed 校验）

> 阶段：**M7**  
> 状态：**core 校验已完成**（2026-11-23）；全 sln 仍为手工/CI 可选

## 范围

| 项 | 说明 |
|----|------|
| `scripts/Verify-SmartentLocalFeed.ps1` | core feed 必备 PackageId 校验；写出 `feed-manifest.txt` |
| `scripts/Pack-SmartentLocalFeed.ps1` | 默认 pack 后自动 verify（`-SkipVerify` 可跳过） |
| `NuGet.config.local.example` | `Lombiq.Analyzers.*` 固定 nuget.org |
| 全量 sln | `Build-NuGetVerify-WithLocalFeed.ps1`（`-Full` pack，非 `-CorePack`） |

## 验证

```powershell
./scripts/Pack-SmartentLocalFeed.ps1
./scripts/Verify-SmartentLocalFeed.ps1
Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
./scripts/Build-NuGetVerify-WithLocalFeed.ps1
```

## 未决

- 远程 Gitee Packages 与 CI 可选 job
- `Smartent.NuGet.Web` Recipe 引用的全部模块包须与 `-Full` pack 清单一致