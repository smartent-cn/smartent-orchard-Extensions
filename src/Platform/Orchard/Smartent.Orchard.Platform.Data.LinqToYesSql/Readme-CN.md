# Smartent.Orchard.Platform.Data.LinqToYesSql

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql`

## 摘要

Smartent.Orchard.Platform.Data.LinqToYesSql：Smartent Orchard Extensions 组件。在 Orchard YesSql 会话上以 LINQ（linq2db）查询数据库的扩展。

## 功能说明

**实现**

- - Smartent Orchard Platform Data (LINQ to YesSql)：在 Orchard YesSql 会话上以 LINQ（linq2db）查询数据库的扩展。

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="src/Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql/Smartent.Orchard.Platform.Data.LinqToYesSql.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.Platform.Data.LinqToYesSql" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`Orchard Core 模块`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 将模块加入宿主，在后台「配置 → 功能」启用，并按需执行 `Recipes/` 下的配方。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `linq2db` | 包引用 | 版本 `6.5.1` |
| `OrchardCore.Data.YesSql` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `MySqlConnector` | 包引用 | 版本 `2.6.2` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | — | — | — | — | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：Driver/Handler/Shape 及模块内接口（见源码）。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql/Smartent.Orchard.Platform.Data.LinqToYesSql.csproj"
dotnet test "src/Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql/Smartent.Orchard.Platform.Data.LinqToYesSql.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
