# Smartent.Orchard.Extensions.Cms

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms`

## 摘要

Smartent.Orchard.Extensions.Cms：Smartent Orchard Extensions 组件。Orchard Core module containing some handy extensions (e.g. useful content types and widgets). It's also available on all sites of DotNest, the Orchard SaaS.

## 功能说明

**实现**

- - Smartent Orchard Extensions for Orchard Core：Orchard Core module containing some handy extensions (e.g. useful content types and widgets). It's also available on all sites of DotNest, the Orchard SaaS.

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.Extensions.Cms" Version="1.0.0" />
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
| `OrchardCore.Autoroute` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Contents` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Flows` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Html` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Lists` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Liquid` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Markdown` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.MetaWeblog.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Rules.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Workflows` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `Scrutor` | 包引用 | 版本 `7.0.0` |
| `HtmlSanitizer` | 包引用 | 版本 `9.2.1039` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `prismjs` | 1.30.0 | dependencies | see package.json scripts |
| `trumbowyg` | 2.31.0 | dependencies | see package.json scripts | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：Driver/Handler/Shape 及模块内接口（见源码）。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj"
dotnet test "src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
