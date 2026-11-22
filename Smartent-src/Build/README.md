# Smartent-src/Build

MSBuild SDK、前端构建与 Orchard 安装相关工程目录。

## 命名策略 | Naming

| 仓库文件夹 | NuGet PackageId | 说明 |
|------------|-----------------|------|
| `Smartent.Build.*` | `Smartent.Build.*` | 迁入时已 Smartent 化（NodeJs、Npm、Tailwind 等） |
| `Lombiq.MSBuild.*` | `Lombiq.MSBuild.*` | **首期只迁目录**，保留 Lombiq 包名与 nupkg 内目录结构；目标草案见 `重构-重组-改名项目方案/M6-PackageId-Exceptions.md` |

Monorepo 内 Orchard 模块/主题工程通过 `Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Module.Sdk` 等 **相对路径** 引用 Sdk；`NuGetBuild=true` 时仍使用 `Sdk="Lombiq.MSBuild.*"` 从包还原。

---

Build tooling: MSBuild SDKs, frontend build, and Orchard setup packages.

## Naming

| Folder | PackageId | Notes |
|--------|-----------|-------|
| `Smartent.Build.*` | `Smartent.Build.*` | Renamed at migration |
| `Lombiq.MSBuild.*` | `Lombiq.MSBuild.*` | **Directory-only move** for now; M7 plans `Smartent.Build.*.Sdk` |

Module/theme projects in the monorepo import Sdk files under `Smartent-src/Build/…`; packaged builds keep `Sdk="Lombiq.MSBuild.*"`.