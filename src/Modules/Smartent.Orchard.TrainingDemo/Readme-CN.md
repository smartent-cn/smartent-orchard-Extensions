# Smartent.Orchard.TrainingDemo (solution)

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.TrainingDemo`

## 摘要

本目录为 `Smartent.Orchard.TrainingDemo` 解决方案根。中文细节见子项目 Readme-CN.md；英文总览见 [Readme.md](Readme.md)。

Smartent.Orchard.TrainingDemo：Smartent Orchard Extensions 组件。Smartent Orchard Training Demo

## 功能说明

**实现**

- - 包含主模块及 Samples/Tests 子工程。
- Smartent Orchard Training Demo：Smartent Orchard Training Demo

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.TrainingDemo (solution)" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`Smartent.Orchard.TrainingDemo, Smartent.Orchard.TrainingDemo.Middlewares`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 将模块加入宿主，在后台「配置 → 功能」启用，并按需执行 `Recipes/` 下的配方。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Microsoft.Web.LibraryManager.Build` | 包引用 | 版本 `3.0.114` |
| `OrchardCore.Users.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Workflows.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.BackgroundTasks` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentFields` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentTypes.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Data.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.DynamicCache` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.FileStorage.FileSystem` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Indexing.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Media.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Module.Targets` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ResourceManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.DisplayManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `Smartent.Orchard.Platform` | 包引用 | 版本 `13.0.1-alpha.5.osoe-344` |
| `MySqlConnector` | 包引用 | 版本 `2.6.2` |
| `HtmlSanitizer` | 包引用 | 版本 `9.2.1039` |

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
dotnet build "src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj"
dotnet test "src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj"
```

子项目各自含 Readme-CN.md。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
