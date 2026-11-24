# src 项目文档索引 | Project documentation index

> 每个 csproj 目录：`Readme.md`（EN）+ `Readme-CN.md`（ZH）。重新生成脚手架：`python scripts/Ensure-BilingualProjectReadmes.py`

## 顶层 | Top level

| 路径 | English | 中文 |
|------|---------|------|
| `src/` | [src/README.md](../../src/README.md) | [src/Readme-CN.md](../../src/Readme-CN.md) |
| `src/Build/` | [Build/README.md](../../src/Build/README.md) | [Build/Readme-CN.md](../../src/Build/Readme-CN.md) |
| `src/Demo/` | [Demo/README.md](../../src/Demo/README.md) | [Demo/Readme-CN.md](../../src/Demo/Readme-CN.md) |

## 产品线 | Product lines

| 区域 | 清单 |
|------|------|
| Platform Core | `src/Platform/Core/Smartent.Core.*/Readme-CN.md` |
| Platform Orchard | `src/Platform/Orchard/Smartent.Orchard.*/Readme-CN.md` |
| Build | `src/Build/Smartent.Build.*/Readme-CN.md` |
| Libraries | `src/Libraries/**/Readme-CN.md` |
| Modules | `src/Modules/**/Readme-CN.md`（含解决方案根 `Modules/<Name>/Readme-CN.md`） |
| Themes | `src/Themes/**/Readme-CN.md` |
| Test | `src/Test/**/Readme-CN.md` |

## 规范 | Standards

- [project-documentation.md](../standards/project-documentation.md)
- [PROJECT_README.en.template.md](../templates/PROJECT_README.en.template.md)
- [PROJECT_README.cn.template.md](../templates/PROJECT_README.cn.template.md)
- 品牌扫描：[Brand-Residual-Scan.md](../migration/Brand-Residual-Scan.md)

## 维护说明 | Maintenance

自动生成的中文/英文文档包含 **依赖表、构建命令、PackageId**；模块特有的 Shape/API/Recipe 步骤需在后续 PR 中人工补充到 **子目录** `Readme-CN.md` 与 `Readme.md`（长文模块可保留英文主文档 + 中文摘要与链接，如 DataTables）。