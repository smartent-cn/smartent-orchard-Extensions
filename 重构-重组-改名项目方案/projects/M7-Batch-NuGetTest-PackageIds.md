# 子方案：M7 批次 #1（NuGetTest 包 ID Smartent 化）

> 阶段：**M7**（首期，不改文件夹/程序集名）  
> 状态：**PackageReference 已切换**（2026-11-22）

## 范围

- `NuGetTest/Directory.Packages.props`：为已迁模块补充 `Smartent.*` 中央版本（与 Lombiq 同名版本对齐）。
- `Lombiq.OSOCE.NuGet.Web`、`Lombiq.OSOCE.NuGet.Tests.UI`：`PackageReference` → `Smartent.*`（模块/主题/Hosting 等）。

**未改**：`Lombiq.OSOCE.NuGet.*` 工程名、Recipe 文件名、独立 sln 名称（避免破坏已有 smoke 文档链接）。

## 验证

```powershell
# 需配置可还原 Smartent 包的 NuGet 源（M7 发布前可能仍失败）
dotnet restore NuGetTest/Lombiq.OSOCE.NuGet.sln
dotnet build NuGetTest/Lombiq.OSOCE.NuGet.sln -c Release
```

主仓门禁仍以 `Smartent.Orchard.sln` 为准。

## 未决

- 将 `NuGetTest/` 重命名为 `NuGetVerify` 并 Smartent 化宿主 csproj 名
- 从中央版本表移除不再发布的 `Lombiq.*` 包项