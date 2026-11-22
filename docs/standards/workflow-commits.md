# 工作流与提交规范 | Workflow & Commits

## 中文

### 重构与功能开发节奏

1. **一次 PR / 提交聚焦一个可验证单元**（单个迁入项目、单个功能、或单组测试修复）。  
2. **完成定义（DoD）**：本节所列测试门禁通过 + 相关中英文 `Readme.md` 已更新（Smartent-src 下为强制）。  
3. **重构迁入**（`Smartent-src/`）：遵循 [第一步-计划.md](../../重构-重组-改名项目方案/第一步-计划.md) 的「迁一删一」；未切换完引用前 **不得** 删除 Legacy 目录。

### 测试门禁（提交前必须满足）

| 变更类型 | 最低验证 |
|----------|----------|
| 仅 `Smartent-src` 下单个库/模块 | 该项目 `dotnet build` + 该项目/模块既有单元测试（若有） |
| 影响主解决方案引用 | `dotnet build Smartent.Orchard.sln` |
| Orchard 模块 / 主题（含前端） | 上项 + `npm`/MSBuild 前端管线成功（见项目 `package.json` 说明） |
| UI 行为变更 | 对应 `*.Tests.UI` 或方案约定的黄金路径用例 |
| 全阶段验收（M6 等） | 仓库级 UI 测试套件全绿 |

构建成功 **不能** 替代 UI/集成测试；适用哪一级由变更范围决定。

### 提交信息

- 使用 **完整说明句**，写清「为什么」；**不要** 在 message 里堆砌 issue 号前缀（与 [.agents/README.md](../../.agents/README.md) 一致）。  
- 重构提交示例：`M2: migrate Common to Smartent.Core.Primitives and update references`  
- 功能提交示例：`Add taxonomy filter API with validation handlers`

### 提交时机

- **仅在当前功能/迁入单元的测试门禁通过后** 再 `git commit`。  
- 用户未要求时 **不要** 主动 push；用户未要求时 **不要** 为半成品功能提交。

### Agent / 自动化

- 改代码后运行与变更匹配的测试命令，并在 PR/会话中简述结果。  
- 未经用户明确要求 **不要** 创建 commit。

---

## English

### Cadence

One PR/commit = one verifiable unit (single migrated project, feature, or test fix). DoD = tests below + bilingual project README updated when under `Smartent-src/`.

### Test gates (before commit)

| Change | Minimum |
|--------|---------|
| Single library in `Smartent-src/` | `dotnet build` on that project + its unit tests if any |
| Solution references touched | Build the main solution |
| Module/theme with frontend | Above + frontend pipeline per `package.json` |
| UI behavior | Relevant `*.Tests.UI` or agreed golden path |
| Milestone acceptance | Full UI suite green |

### Commit messages

Complete sentences, focus on why; no issue-key prefix in the subject (see `.agents/README.md`).

### When to commit

Only after the test gate for the current unit passes. Do not commit or push unless the user asks.