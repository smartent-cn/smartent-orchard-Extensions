# `Smartent-src` → `src`（2026-11-23）

| 项 | 说明 |
|----|------|
| 产品代码根 | 仓库根 **`src/`**（`Platform/`、`Build/`、`Modules/`、`Themes/`、`Demo/`、`Test/`、`Libraries/`） |
| 原 Legacy `src/` | 仅剩指针 `README.md`，已删除；归档说明 **`src-old/README.md`** |
| MSBuild | `SmartentSrcPath` 指向 `$(SmartentSolutionRootPath)/src`（属性名未改） |
| 文档 | 全文 `Smartent-src/` 路径已改为 `src/`；对照表文件名仍为 `Legacy-to-Smartent-src-Mapping.md` |

验证：`dotnet build Smartent.Orchard.sln -c Release`，`./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack`。