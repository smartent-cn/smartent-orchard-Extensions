# 项目说明文档规范 | Project Documentation Standards

## 中文

### 适用范围

| 位置 | 文件名 | 是否必须中英文 |
|------|--------|----------------|
| `src/**` 下每个 **可构建 csproj 目录** | `Readme.md`（**英文**）+ `Readme-CN.md`（**中文**） | **必须** |
| Legacy `src/**` 在迁入完成前 | 原 `Readme.md` | 迁入时在 Smartent 副本中补全双文件 |
| 仅测试/样例、不单独发布 | 可合并到父项目 Readme | 须在父文档 `Readme-CN.md` 列出子项目 |

模板（双文件）：

- 英文：[PROJECT_README.en.template.md](../templates/PROJECT_README.en.template.md)
- 中文：[PROJECT_README.cn.template.md](../templates/PROJECT_README.cn.template.md)
- 合并版（旧）：[PROJECT_README.template.md](../templates/PROJECT_README.template.md)

批量补齐：`python scripts/Ensure-BilingualProjectReadmes.py`（生成后须人工校对技术细节）。

### `docs/` 分主题目录（非测试项目强制）

适用于 `src/**` 下每个 **含 `.csproj` 的项目目录**。

**排除**：`src/Test/**`；`**/*.Tests*`、`**/*.Tests.UI*`、`**/*.Tester*`、`**/*Benchmark*`（仅这些免 `docs/`）。

| 路径 | 说明 |
|------|------|
| `Docs-Index.md` / `Docs-Index-CN.md` | 项目根索引 |
| `docs/README.md` / `docs/Readme-CN.md` | 分主题目录 |
| `docs/QuickStart*`、`Usage*`、`Configuration*`、`Cautions*` | 怎么用 / 注意什么 |

模板：`docs/templates/MODULE_DOCS_FOLDER_README.*`、`MODULE_ROOT_DOCS_INDEX.*`（通用项目同款）  
总索引：[docs/src-projects/README.md](../src-projects/README.md)  
脚本：`python scripts/Ensure-ProjectDocsFolders.py`  
Cursor 规则：`.cursor/rules/project-docs-folder.mdc`

### 必备章节（顺序建议固定）

1. **标题与一句话摘要**（英文在 `Readme.md`，中文在 `Readme-CN.md`；文首互相链接）  
2. **功能说明 | Features** — 实现了什么，不做什么（边界）  
3. **引用方式 | References** — monorepo `ProjectReference` 路径示例 + 未来 NuGet `PackageReference` 示例  
4. **使用方式 | Usage** — 启用哪些 Orchard Feature、配置项、Recipe、示例代码或管理端路径  
5. **依赖说明 | Dependencies** — .NET / Orchard 包；若有前端见 [frontend-dependencies.md](frontend-dependencies.md)  
6. **升级与扩展 | Upgrade & Extension** — 与 Orchard 版本关系、扩展点（Handler/Driver/接口）、已知限制、Smartent 自定义时注意点  
7. **测试 | Tests** — 如何运行、门禁命令  
8. **来源与许可 | Provenance** — 若自 Lombiq 迁入，注明原项目名与许可

### 引用方式章节必须包含

```markdown
### 引用方式 | References

**Monorepo（开发）**
\`\`\`xml
<ProjectReference Include="..\..\..\src\Platform\Core\Smartent.Core.Primitives\Smartent.Core.Primitives.csproj" />
\`\`\`

**NuGet（发布后，版本号以实际发布为准）**
\`\`\`xml
<PackageReference Include="Smartent.Core.Primitives" Version="1.0.0" />
\`\`\`
```

路径随实际项目调整；**禁止** 只写「引用 HelpfulLibraries」而不写具体包。

### 维护义务

- 完成迁入或功能且 **测试通过后**，在同一 PR 内更新 `Readme.md`。  
- 增删 `PackageReference` / `package.json` 依赖时，**同步** 更新依赖说明表。  
- PackageId、模块 Id、命名空间变更时，**同步** 更新引用示例。

### 代码与文档语言分工

- **项目文档**：`Readme.md` = English；`Readme-CN.md` = 中文；文首交叉链接。  
- **代码公共 API**：中文 XML 文档（见 [csharp.md](csharp.md)）。

---

## English

Every non-test project under `src/` must have **`Readme.md` + `Readme-CN.md`**, plus **`docs/`** and **`Docs-Index`** (see above). Excludes `src/Test/**` and `*.Tests*` projects. Index: `docs/src-projects/`. Run `Ensure-BilingualProjectReadmes.py` and `Ensure-ProjectDocsFolders.py`; human review required.