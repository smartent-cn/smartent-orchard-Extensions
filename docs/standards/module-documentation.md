# Orchard 模块文档规范 | Module documentation

> 模块与 Build/Platform/Themes 等 **同一套** `docs/` 规则，见 [project-documentation.md](project-documentation.md)。总索引：[docs/src-projects/README.md](../src-projects/README.md)。

## 模块家族（`src/Modules/<家族>/`）

### 三层文档结构

| 层级 | 路径 | 作用 |
|------|------|------|
| 仓库总索引 | [docs/src-projects/README.md](../src-projects/README.md)（Modules 一节） | 全部非测试项目 |
| 模块捷径 | [docs/modules/README.md](../modules/README.md) | 指向 src-projects |
| 家族根 | `Readme.md`、`Readme-CN.md` | 模块总览（加厚模板） |
| 家族根 | `Docs-Index.md`、`Docs-Index-CN.md` | 指向 `docs/` 与总览 |
| 分主题 | `docs/README.md`、`docs/Readme-CN.md` | 本模块专题索引 |
| 分主题 | `docs/QuickStart*`、`Usage*`、`Configuration*`、`Cautions*` | 怎么用、注意什么 |

顺序固定：**AuditTrail → … → Walkthroughs**（与 [src/Modules/README.md](../../src/Modules/README.md) 一致）。

### 模板

| 用途 | 文件 |
|------|------|
| 模块总览 EN/CN | [MODULE_README.en.template.md](../templates/MODULE_README.en.template.md)、[MODULE_README.cn.template.md](../templates/MODULE_README.cn.template.md) |
| 家族根索引 | [MODULE_ROOT_DOCS_INDEX.en.template.md](../templates/MODULE_ROOT_DOCS_INDEX.en.template.md)、[.cn.template.md](../templates/MODULE_ROOT_DOCS_INDEX.cn.template.md) |
| `docs/` 目录索引 | [MODULE_DOCS_FOLDER_README.en.template.md](../templates/MODULE_DOCS_FOLDER_README.en.template.md)、[.cn.template.md](../templates/MODULE_DOCS_FOLDER_README.cn.template.md) |

### 脚本

```powershell
python scripts/Thicken-ModuleReadmes.py      # 加厚模块 Readme（Modules）
python scripts/Ensure-ProjectDocsFolders.py  # 全 src 非测试项目的 docs/
```

生成后须人工校对；复杂子包（Hosting.Tenants 子项目、Marketing.Pirsch 等）在各自 csproj 目录继续加厚。

### csproj 目录

可发布的模块 csproj 目录仍须 [project-documentation.md](project-documentation.md) 中的 `Readme.md` + `Readme-CN.md`。

---

## English

Each module family under `src/Modules/` must have root `Docs-Index` files, a `docs/` folder with bilingual topic indexes and QuickStart/Usage/Configuration/Cautions files, and entries in `docs/modules/`. Update docs when features, configuration, or public API change. Run `Ensure-ModuleDocsFolders.py` after adding a new module family.