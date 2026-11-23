# {Smartent.Package.Id} | {English Product Name}

> **状态 | Status**: 草稿 Draft / 已迁入 src Migrated / 已发布 NuGet Published  
> **路径 | Path**: `src/...`

---

## 摘要 | Summary

**中文**：一句话说明本项目职责与适用场景。

**English**: One sentence describing responsibility and when to use this package.

---

## 功能说明 | Features

### 中文

- 实现：
- 不实现（边界）：

### English

- Implements:
- Out of scope:

---

## 引用方式 | References

### Monorepo（开发 | Development）

```xml
<!-- 按实际相对路径调整 Adjust relative path -->
<ProjectReference Include="PATH\TO\{Project}.csproj" />
```

### NuGet（发布后 | When published）

```xml
<PackageReference Include="{Smartent.Package.Id}" Version="1.0.0" />
```

### Orchard 模块依赖（如适用 | If Orchard module）

- 需在宿主中启用的 Feature：
- 可选依赖模块：

---

## 使用方式 | Usage

### 中文

1. 引用本项目后 …
2. 在管理端 … / 在代码中 …

### English

1. After referencing …
2. In admin / in code …

---

## 依赖说明 | Dependencies

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| OrchardCore.Abstractions | Package | … |

### 前端（无则删本节 | Delete section if N/A）

见 [frontend-dependencies 规范](../standards/frontend-dependencies.md)。

| npm 包 | 版本 | 用途 | 构建命令 |
|--------|------|------|----------|
| | | | |

---

## 升级与扩展 | Upgrade & Extension

### 中文

- **Orchard 版本**：与仓库 `OrchardCoreVersion` 关系
- **扩展点**：接口 / Handler / Driver / …
- **后续 Smartent 定制**：注意 …

### English

- Orchard version alignment
- Extension points
- Smartent customization notes

---

## 测试 | Tests

```powershell
dotnet build PATH\TO\{Project}.csproj
dotnet test PATH\TO\{Project}.Tests.csproj
```

---

## 来源与许可 | Provenance & License

- 若自 Lombiq/OSOCE 迁入：原项目名、许可证（MIT 等）
- Copyright：Smartent（衍生部分）