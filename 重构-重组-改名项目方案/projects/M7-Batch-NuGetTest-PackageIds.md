# 子方案：M7 批次 #1（NuGetTest 包 ID Smartent 化）

> 阶段：**M7**  
> 状态：**已完成**（NuGetVerify / Smartent.NuGet.*，2026-11-22）

## 范围

- `NuGetVerify/Directory.Packages.props`：`Smartent.*` 中央版本；Lombiq 例外仅 `Lombiq.Analyzers.OrchardCore`（2026-11-24 已去掉 `HelpfulLibraries.OrchardCore` / `Lombiq.Tests`）。
- `Smartent.NuGet.Web`、`Smartent.NuGet.Tests.UI`：`PackageReference` → `Smartent.*`。
- 目录 `NuGetTest` → `NuGetVerify`；sln `Smartent.NuGet.sln`；工程/Recipe 前缀 `Smartent.NuGet.*`。

## 验证

```powershell
dotnet build NuGetVerify/Smartent.NuGet.Monorepo.sln -c Release
# 全量 sln：scripts/Build-NuGetVerify-WithLocalFeed.ps1 + NuGet.config.local
```

主仓门禁仍以 `Smartent.Orchard.sln` 为准；CI NuGet 作业使用 `Smartent.NuGet.Monorepo.sln`。

## 未决

- M7 发布：Smartent 包上源后 `NuGetVerify` 仅 PackageReference 构建绿