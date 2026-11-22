# 子方案：M7 批次 #3（本地 NuGet feed）

> 阶段：**M7**  
> 状态：**进行中**（2026-11-23）

## 范围

| 项 | 说明 |
|----|------|
| `scripts/Pack-SmartentLocalFeed.ps1` | 默认 pack Platform / Module.Sdk / TrainingDemo；`-Full` = 全 `Smartent.Orchard.sln` |
| `artifacts/smartent-nuget-local/` | 本地 feed 输出目录（gitignore） |
| `NuGetVerify/NuGet.config` | 注释占位 `SmartentLocal` 源 |
| 根 `Reset-Local.ps1` | 指向 `Smartent-src/Demo/Smartent.Demo.Web/App_Data` |

## 验证

```powershell
./scripts/Pack-SmartentLocalFeed.ps1
dotnet build NuGetVerify/src/Modules/Smartent.NuGet.TestModule/Smartent.NuGet.TestModule.csproj -c Release
# 全量 NuGetVerify Web：Pack -Full 并启用 NuGet.config 中 SmartentLocal 后
# dotnet build NuGetVerify/Smartent.NuGet.sln -c Release
```

## 未决

- Gitee Packages 定稿 URL 与 CI secret
- `NuGetVerify` Web 全绿依赖 feed 内 **全部** Recipe 引用包（与 `-Full` pack 一致）