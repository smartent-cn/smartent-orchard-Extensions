# Smartent-src/Build

MSBuild SDK、前端构建与 Orchard 安装相关工程目录。

## 命名策略 | Naming

| 仓库文件夹 | NuGet PackageId | 说明 |
|------------|-----------------|------|
| `Smartent.Build.*` | `Smartent.Build.*` | MSBuild Sdk、LibMan、NodeJs、Npm、Tailwind 等（Sdk 默认版本 **2.1.1**） |

Monorepo 内 Orchard 模块/主题工程通过 `Smartent-src/Build/Smartent.Build.OrchardCore.Module.Sdk` 等 **相对路径** 引用 Sdk；`NuGetBuild=true` 时使用 `Sdk="Smartent.Build.*"` 从 feed / nuget.org 还原。

`src/Utilities/Lombiq.MSBuild.Targets/` 仅保留 **Sdk.Samples**、**Targets.Samples**、**Targets.Tests** 与 Docs；各 `Lombiq.MSBuild.*` 子目录为迁一删一 **Readme 占位**。

---

Build tooling: MSBuild SDKs, frontend build, and Orchard setup packages.

## Naming

| Folder | PackageId | Notes |
|--------|-----------|-------|
| `Smartent.Build.*` | `Smartent.Build.*` | Folders and NuGet ids aligned (M7#11) |

Module/theme projects in the monorepo import Sdk files under `Smartent-src/Build/…`; packaged builds keep `Sdk="Smartent.Build.*"`.