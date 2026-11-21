# 项目说明文档规范 | Project Documentation Standards

## 中文

### 适用范围

| 位置 | 文件名 | 是否必须中英文 |
|------|--------|----------------|
| `Smartent-src/**` 下每个 **可构建 csproj 目录** | `Readme.md` | **必须** |
| Legacy `src/**` 在迁入完成前 | 原 `Readme.md` | 迁入时在 Smartent 副本中补全双语 |
| 仅测试/样例、不单独发布 | 可合并到父项目 Readme | 须在父文档列出子项目 |

模板：[PROJECT_README.template.md](../templates/PROJECT_README.template.md)

### 必备章节（顺序建议固定）

1. **标题与一句话摘要**（中文段 + English section）  
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
<ProjectReference Include="..\..\..\Smartent-src\Platform\Core\Smartent.Core.Primitives\Smartent.Core.Primitives.csproj" />
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

- **项目 Readme**：中英文对照（可先完整中文块，再完整 English block）。  
- **代码公共 API**：中文 XML 文档（见 [csharp.md](csharp.md)）。

---

## English

Every buildable project under `Smartent-src/` must have a bilingual `Readme.md` using the template sections: features, references (ProjectReference + PackageReference), usage, dependencies, upgrade/extension notes, tests, provenance. Update README in the same PR when dependencies or public API change.