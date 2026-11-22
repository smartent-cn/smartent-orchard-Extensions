# NuGet 发布验证 | NuGet publish smoke tests

**中文**：独立解决方案，用于验证从 NuGet 源安装的包。

- **前**（Web / 单测）：显式 `Smartent.*` 包引用，已去掉 `Lombiq.HelpfulLibraries` 元包。  
- **后**（模块 Sdk）：在 **本 monorepo 内** 构建时 `UseSmartentMonorepoMsBuildSdk` 为 true，TestModule 引用仓库内 Module.Sdk（`Smartent.Orchard.Platform`）。独立检出 NuGetVerify 时仍用 nuget Sdk 2.1.1 + `Lombiq.HelpfulLibraries.OrchardCore`。  
- Smartent 包尚未在 nuget.org 发布时，在仓库根运行 `scripts/Pack-SmartentLocalFeed.ps1`（`-Full` 打包全 sln），再于 `NuGet.config` 启用 `SmartentLocal` 源指向 `artifacts/smartent-nuget-local`。
- 在本 monorepo 内仅验证 TestModule：无需 feed，`dotnet build NuGetVerify/src/Modules/Smartent.NuGet.TestModule/...` 即可。

**English**: Standalone solution to smoke-test packages restored from NuGet feeds, including Smartent platform packages. The meta-package `Lombiq.HelpfulLibraries` is not used here. Module/theme package IDs in the Web and UI test projects use **`Smartent.*`** (see `projects/M7-Batch-NuGetTest-PackageIds.md`).

| 解决方案 | 用途 |
|----------|------|
| `Smartent.NuGet.Monorepo.sln` | CI / 单体仓：Module·Theme·Tests·NodeJs（无 Web / Tests.UI） |
| `Smartent.NuGet.sln` | 全量包引用验证（需本地 feed 或 Gitee Packages） |

See also `重构-重组-改名项目方案/projects/M3-HelpfulLibraries-MetaPackage.md`.