# Legacy `src/` 指针 | Legacy src pointers

产品代码已迁入 [`Smartent-src/`](../Smartent-src/README.md)。本目录下多数文件夹 **仅保留 `Readme.md`**，说明对应 Smartent 路径（迁一删一）。

删除任何 Legacy 子目录前，更新并核对全表：[docs/migration/Legacy-to-Smartent-src-Mapping.md](../docs/migration/Legacy-to-Smartent-src-Mapping.md)。

| 区域 | Smartent 目标 |
|------|----------------|
| `Libraries/Lombiq.HelpfulLibraries` | 已迁入 `Smartent-src/Platform/`；Legacy 仅 Readme |
| `Utilities/Lombiq.MSBuild.Targets` | **shim** + Readme；产物在 `Smartent-src/Build/` |
| `Modules/Lombiq.*` | `Smartent-src/Modules/Smartent.Orchard.*` |
| `Themes/Lombiq.*` | `Smartent-src/Themes/` |
| `Lombiq.OSOCE.Web` | `Smartent-src/Demo/Smartent.Demo.Web` |

主解决方案：**`Smartent.Orchard.sln`**（仓库根目录）。