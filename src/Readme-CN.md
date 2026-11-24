# src — 产品代码树

> **English**: [README.md](README.md)（与本文互为补充）

本目录是 **Smartent 产品代码唯一根目录**。与旧路径对照：[docs/migration/Legacy-to-Smartent-src-Mapping.md](../docs/migration/Legacy-to-Smartent-src-Mapping.md)

## 目录约定

| 路径 | 用途 |
|------|------|
| `Platform/Core/` | 无 Orchard 依赖：`Smartent.Core.*` |
| `Platform/Orchard/` | Orchard 开发底座：`Smartent.Orchard.Platform.*` |
| `Build/` | MSBuild SDK、Npm、Node、Tailwind、Setup（见 [Build/Readme-CN.md](Build/Readme-CN.md)） |
| `Libraries/` | ApiClient、EInvoice 等独立库 |
| `Modules/` | Orchard 模块 |
| `Themes/` | 主题 |
| `Demo/` | 演示 Web、聚合样例 |
| `Test/` | 测试工具与验收项目 |

## Orchard 模块文档

- 总索引：[docs/src-projects/Readme-CN.md](../docs/src-projects/Readme-CN.md)  
- 模块树：[Modules/Readme-CN.md](Modules/Readme-CN.md)（AuditTrail → Walkthroughs，各家族含 `docs/`）

## 项目文档义务

- 每个 **非测试 csproj 所在目录** 必须包含：
  - **`Readme.md`**、**`Readme-CN.md`**
  - **`Docs-Index.md`**、**`Docs-Index-CN.md`**
  - **`docs/`**（QuickStart / Usage / Configuration / Cautions，中英）
- 两文件文首须互相链接。
- 批量生成脚手架：`python scripts/Ensure-BilingualProjectReadmes.py`（生成后须人工校对业务细节与前端依赖表）。
- 规范全文：[docs/standards/project-documentation.md](../docs/standards/project-documentation.md)

## 迁移与门禁

1. 新路径 `dotnet build` 通过。  
2. `Smartent.Orchard.sln` 无 ProjectReference 指向 Legacy 路径。  
3. 约定测试通过后再提交（见 `docs/standards/workflow-commits.md`）。  
4. 本 demo 仓库 **不** 维护 `CompatibilitySuppressions.xml` 与 `Lombiq_*` 配置双读。

## 品牌残留扫描

见 [docs/migration/Brand-Residual-Scan.md](../docs/migration/Brand-Residual-Scan.md)。