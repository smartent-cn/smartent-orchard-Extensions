# 子方案：M7 批次 #1（NuGetTest 包 ID Smartent 化）

> 阶段：**M7**  
> 状态：**NuGetVerify / Smartent.NuGet.\***（2026-11-22）

## 范围

- `NuGetVerify/Directory.Packages.props`：`Smartent.*` 中央版本；已移除仅 Lombiq 的旧模块包项（保留 `Lombiq.Analyzers.OrchardCore`、`Lombiq.HelpfulLibraries.OrchardCore` 例外）。
- `Smartent.NuGet.Web`、`Smartent.NuGet.Tests.UI`：`PackageReference` → `Smartent.*`。
- 目录 `NuGetTest` → `NuGetVerify`；sln `Smartent.NuGet.sln`；工程/Recipe 前缀 `Smartent.NuGet.*`。

## 验证

```powershell
# 需配置可还原 Smartent 包的 NuGet 源（M7 发布前可能仍失败）
dotnet restore NuGetVerify/Smartent.NuGet.sln
dotnet build NuGetVerify/Smartent.NuGet.sln -c Release
```

主仓门禁仍以 `Smartent.Orchard.sln` 为准。

## 未决

- M7 发布：Smartent 包上源后 `NuGetVerify` 仅 PackageReference 构建绿