# Smartent.Orchard.ContentEditors

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors`

## 摘要

Smartent.Orchard.ContentEditors：Smartent Orchard Extensions 组件。Module for managing advanced content editing processes based on editor groups and asynchronous operations.

## 功能说明

**实现**

- - Smartent Orchard Content Editors for Orchard Core：Module for managing advanced content editing processes based on editor groups and asynchronous operations.

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../../Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.Resources/Smartent.Orchard.VueJs.Resources.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.ContentEditors" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`（见 Manifest / Module.cs）`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 将模块加入宿主，在后台「配置 → 功能」启用，并按需执行 `Recipes/` 下的配方。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `OrchardCore.ContentFields` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentTypes.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.DisplayManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Media` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ResourceManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `Smartent.Orchard.VueJs.Resources` | 包引用 | 版本 `10.0.0` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `vue-router` | 4.5.1 | dependencies | see package.json scripts | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：Driver/Handler/Shape 及模块内接口（见源码）。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.csproj"
dotnet test "src/Modules/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors/Smartent.Orchard.ContentEditors.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
