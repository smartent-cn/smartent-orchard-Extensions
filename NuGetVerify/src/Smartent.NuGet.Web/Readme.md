# Smartent NuGet verification web app

**中文**：NuGetVerify 中的 Orchard Core 宿主站点，用于从 NuGet feed 还原 `Smartent.*` 包后的冒烟与 UI 测试。配方见 `Recipes/`（如 `Smartent.NuGet.Tests`）。

**English**: Orchard Core web host for NuGetVerify — smoke and UI tests after restoring `Smartent.*` packages from a feed. Setup recipes live under `Recipes/` (e.g. `Smartent.NuGet.Tests`).

```powershell
dotnet build Smartent.NuGet.Web.csproj -c Release
```

See [NuGetVerify/Readme.md](../../../Readme.md) and [M7-Batch-NuGetTest-PackageIds.md](../../../重构-重组-改名项目方案/projects/M7-Batch-NuGetTest-PackageIds.md).