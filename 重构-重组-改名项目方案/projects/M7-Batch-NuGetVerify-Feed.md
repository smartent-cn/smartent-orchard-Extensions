# 子方案：M7 批次 #2（NuGet 源与 Sdk 冒烟）

> 阶段：**M7**  
> 状态：**Monorepo 冒烟已完成**（2026-11-23）；远程源与全 sln 见批次 #7

## 范围

| 项 | 说明 |
|----|------|
| 根 `NuGet.config` / `NuGetVerify/NuGet.config` | 注释占位 Smartent 包源（Gitee Packages 示例 URL） |
| `Update-SmartentNuGetPackages.ps1` | 原 `Update-LombiqNuGetPackages.ps1`，过滤 `Smartent.*` |
| `Smartent.Build.Sdk.NuGet.Samples` | 单体仓内 pack 冒烟，`Smartent.Orchard.Platform` 依赖 |

## 验证

```powershell
$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet test src/Build/Smartent.Build.Targets.Tests/Smartent.Build.Targets.Tests.csproj -c Release
dotnet build NuGetVerify/Smartent.NuGet.Monorepo.sln -c Release
dotnet build src/Build/Smartent.Build.LibMan.Targets/Smartent.Build.LibMan.Targets.csproj -c Release
dotnet pack src/Build/Smartent.Build.Library.Sdk/Smartent.Build.Library.Sdk.csproj -c Release
dotnet pack src/Build/Smartent.Build.OrchardCore.Theme.Sdk/Smartent.Build.OrchardCore.Theme.Sdk.csproj -c Release
```

## 未决

- Smartent feed URL 定稿并启用 `NuGetVerify` 全 sln 仅 PackageReference 构建