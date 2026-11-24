# src/Build

> **English**: [README.md](README.md)

MSBuild SDK、前端构建工具链与 Orchard 安装相关工程。

## 命名与 PackageId

| 仓库文件夹 | NuGet PackageId | 说明 |
|------------|-----------------|------|
| `Smartent.Build.*` | `Smartent.Build.*` | Sdk、LibMan、NodeJs、Npm、Tailwind 等 |

Monorepo 内 Orchard 模块/主题通过 **相对路径** 引用 `src/Build/Smartent.Build.OrchardCore.Module.Sdk` 等；`NuGetBuild=true` 时使用 `Sdk="Smartent.Build.*"` 从 feed 还原。

## 子项目文档

每个 `Smartent.Build.*` 的 csproj 目录下均有 **`Readme.md` + `Readme-CN.md`**，以及 **`docs/`** + **`Docs-Index`**（见 [docs/src-projects/Readme-CN.md](../../docs/src-projects/Readme-CN.md)）。MSBuild 用法总览见 [Docs/UsingMSBuildSdks.md](Docs/UsingMSBuildSdks.md) 及各 Sdk 目录中文说明。

## 测试与样例

- `Smartent.Build.Sdk.Samples`、`Smartent.Build.Targets.*`：LibMan / pack 样例  
- `Smartent.Build.NodeJs.Samples`、`Smartent.Build.Tailwind.Samples`：前端构建样例  

## 相关路径

- 全局属性：`build/Smartent.Orchard.props`、`build/Smartent.Packaging.props`  
- Legacy `src/Utilities/Smartent.MSBuild.Targets/` 仅 Readme 占位（迁一删一）