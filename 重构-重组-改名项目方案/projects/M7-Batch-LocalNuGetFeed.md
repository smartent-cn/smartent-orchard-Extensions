# 子方案：M7 批次 #3（本地 NuGet feed）

> 阶段：**M7**  
> 状态：**单体仓 CI 已完成**（2026-11-23）；全 sln + 远程源见批次 #6

## 范围

| 项 | 说明 |
|----|------|
| `scripts/Pack-SmartentLocalFeed.ps1` | 默认 pack Platform / Module.Sdk / TrainingDemo；`-Full` = 全 `Smartent.Orchard.sln` |
| `scripts/Build-NuGetVerify-WithLocalFeed.ps1` | `-Full` pack + `NuGet.config.local` 还原/构建全 `Smartent.NuGet.sln` |
| `NuGetVerify/Smartent.NuGet.Monorepo.sln` | CI 门禁（无 Web / Tests.UI；走 `UseSmartentMonorepoMsBuildSdk`） |
| `NuGetVerify/NuGet.config.local.example` | 本地 feed 源模板 |
| `artifacts/smartent-nuget-local/` | 本地 feed 输出目录（gitignore） |
| `NuGetVerify/NuGet.config` | 注释占位 `SmartentLocal` 源 |
| 根 `Reset-Local.ps1` | 指向 `src/Demo/Smartent.Demo.Web/App_Data` |

## 验证

```powershell
./scripts/Pack-SmartentLocalFeed.ps1
dotnet build NuGetVerify/Smartent.NuGet.Monorepo.sln -c Release
./scripts/Pack-SmartentLocalFeed.ps1
./scripts/Verify-SmartentLocalFeed.ps1
# 全量 NuGetVerify Web：
# Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
# ./scripts/Build-NuGetVerify-WithLocalFeed.ps1
```

## 未决

- Gitee Packages 定稿 URL 与 CI secret
- `NuGetVerify` Web 全绿依赖 feed 内 **全部** Recipe 引用包（与 `-Full` pack 一致）