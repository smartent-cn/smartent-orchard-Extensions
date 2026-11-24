# Lombiq / 兼容层残留扫描 | Brand residual scan

> **扫描日期**：2026-11-24 · 范围：`src/` 产品树 + 仓库根配置（不含 `重构-重组-改名项目方案/` 历史档案）

## 结论 | Summary

**中文**：`src/` 下 **运行时代码与配置** 已基本 Smartent 化；剩余 “Lombiq/lombiq” 多为 **文档外链、MSBuild 内部标识、工具子模块上游 GHA、Cloudsmith feed 路径**。本培训/demo 仓库 **不保留** `Lombiq_*` 配置双读与 `CompatibilitySuppressions.xml`。**未改项可延后**，遇 CI/发布/还原失败时再处理。

**English**: Product code under `src/` is largely rebranded. Remaining hits are mostly docs URLs, VueJs MSBuild property names, tools submodule workflows, and Cloudsmith URLs. No Lombiq config fallbacks in this repo. Defer low-priority items until they block a build or publish.

---

## `src/` 仍含 Lombiq 字样的文件（按类别）

| 类别 | 路径示例 | 建议 |
|------|----------|------|
| 文档 / 案例 URL | 各 `Readme.md` 中 `lombiq-com` 博客链 | 保留或改为 Smartent 案例；非阻塞 |
| VueJs MSBuild | `Smartent.Orchard.VueJs.props` / `.targets`（`LombiqVueJs*` 等内部名） | 下次改 Vue 构建时再批量更名 |
| TrainingDemo | VS 扩展市场注释、`Reset-Local.ps1`、`.gitignore` | 低优先级 |
| NodeJs 构建 | `Common.props`、`CreateGlobalConfigFiles.targets` 注释/路径 | 低优先级 |
| Theme SCSS 注释 | `_base.scss` 提及 Lombiq.NodeJs | 注释级 |
| DotSettings / NLog | `Folder.DotSettings`、`NLog.config` | 字典/布局名；按需 |
| Cloudsmith | `Smartent.Test.UI/.github/workflows/publish-cloudsmith.yml` | Smartent feed 就绪后改 |

**已无**：`CompatibilitySuppressions.xml`（`src/`）、`Lombiq_Hosting_*` 配置节双读（Marketing/TrainingDemo）。

---

## 仓库其他区域

| 区域 | 说明 |
|------|------|
| `tools/Smartent.GitHub.Actions` | `uses: Lombiq/GitHub-Actions@…`、Jira/Cloudsmith 示例 |
| `NuGetVerify/`、`License.md` | Copyright、feed 基线 |
| `.github/workflows` | 引用 tools 子模块内 Lombiq 上游 |

---

## 复扫命令 | Rescan

```powershell
rg -i "lombiq" src --glob "!**/obj/**" --glob "!**/bin/**"
rg "CompatibilitySuppressions" .
```