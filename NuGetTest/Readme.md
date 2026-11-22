# NuGet 发布验证 | NuGet publish smoke tests

**中文**：独立解决方案，用于验证从 NuGet 源安装的包。

- **前**（Web / 单测）：显式 `Smartent.*` 包引用，已去掉 `Lombiq.HelpfulLibraries` 元包。  
- **后**（模块 Sdk）：当前仍用 nuget.org 上的 `Lombiq.MSBuild.OrchardCore.*.Sdk` 2.1.1，会注入 `Lombiq.HelpfulLibraries.OrchardCore`；待 M4 发布 Smartent Sdk 后移除。  
- Smartent 包尚未在 nuget.org 发布时，需配置自有 NuGet 源或本地 feed 后再 `dotnet restore`。

**English**: Standalone solution to smoke-test packages restored from NuGet feeds, including Smartent platform packages. The meta-package `Lombiq.HelpfulLibraries` is not used here.

See also `重构-重组-改名项目方案/projects/M3-HelpfulLibraries-MetaPackage.md`.