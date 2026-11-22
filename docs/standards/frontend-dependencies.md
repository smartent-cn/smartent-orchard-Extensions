# 前端与 npm 依赖说明规范 | Frontend & npm Documentation

## 中文

### 适用范围

凡包含以下任一项的工程，视为 **带前端项目**，`Readme.md` 中 **必须** 有「前端依赖说明」专节（中英文）：

- 根或子目录 `package.json`  
- `Smartent.Build.NodeJs`（原 `Lombiq.NodeJs.Extensions`）/ MSBuild npm 目标驱动的 `Assets/`、`*.scss`、`*.js` 编译到 `wwwroot`  
- Vue / Chart.js / DataTables / UIKit 等模块内嵌脚本  
- Theme 内 Bootstrap / LibMan / Tailwind 管线  

### 前端依赖说明专节必须包含的表格

| 列名 | 说明 |
|------|------|
| 依赖名 | npm 包名或 Bundled 库名 |
| 版本 | `package.json` 中版本范围或 lock 策略 |
| 用途 | 在本项目中做什么（中文 + English one line） |
| 构建入口 | 如 `npm run build`、`dotnet build` 触发的 target 名 |
| 输出目录 | 如 `wwwroot/**` 路径 |
| 升级注意 | 与 Orchard ResourceManifest、CSP、模块序号的耦合点 |

### Node.js 环境

- 在 Readme 中写明 **推荐 Node 大版本**（与 `Smartent.Build.NodeJs` / 仓库 CI 一致；写能力不写死号时参见 [.agents 文档策略](../../.agents/README.md)）。  
- 说明是否必须全局安装某 CLI，或仅本地 `npm ci`。

### Orchard 资源注册

- 说明 JavaScript/CSS 如何通过 `ResourceManagement` 注册、依赖哪些 `asp-*` 脚本。  
- 若依赖 `Smartent.Orchard.Platform.*` 或 CSP Provider，写明模块启用顺序。

### 示例（片段）

```markdown
## 前端依赖说明 | Frontend dependencies

| 依赖 | 版本 | 用途 | 构建 |
|------|------|------|------|
| vue | ^3.x | 管理端 Vue 组件宿主 | `npm run build` in `Lombiq.VueJs/` |

**升级注意**：升级 Vue 主版本需同步更新 `Scripts` 清单与 UI 测试快照。
```

### 验证

带前端的 PR 在提交前除 `dotnet build` 外，须按项目 Readme 执行 **npm 安装与前端构建**（若 CI 有对应 job，以对齐 CI 为准）。

---

## English

Projects with `package.json` or MSBuild-driven front-end assets must document npm deps in a dedicated bilingual section: name, version, purpose, build entry, output paths, upgrade caveats (Orchard resources, CSP, tests). Verify npm build per README before commit.