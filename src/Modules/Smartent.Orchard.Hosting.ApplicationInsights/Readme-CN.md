# Smartent.Orchard.Hosting.ApplicationInsights (solution)

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.Hosting.ApplicationInsights`

## 摘要

本目录为 `Smartent.Orchard.Hosting.ApplicationInsights` 解决方案根。中文细节见子项目 Readme-CN.md；英文总览见 [Readme.md](Readme.md)。

Smartent.Orchard.Hosting.ApplicationInsights：Smartent Orchard Extensions 组件。This Orchard Core module enables easy integration of Azure Application Insights telemetry into Orchard. Just install the module, configure the instrumentation key from a configuration source, and collected data will start appearing in the Azure Portal.

## 功能说明

**实现**

- - 包含主模块及 Samples/Tests 子工程。
- Smartent Orchard Hosting - Azure Application Insights for Orchard Core：This Orchard Core module enables easy integration of Azure Application Insights telemetry into Orchard. Just install the module, configure the instrumentation key from a configuration source, and collected data will start appearing in the Azure Portal.

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.Hosting.ApplicationInsights (solution)" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`（见 Manifest / Module.cs）`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 启用租户/托管相关功能，并在 `appsettings.json` 配置 `OrchardCore:Smartent_Orchard_Hosting_*`。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Azure.Identity` | 包引用 | 版本 `1.21.0` |
| `Microsoft.ApplicationInsights.AspNetCore` | 包引用 | 版本 `2.23.0` |
| `Microsoft.ApplicationInsights.Profiler.AspNetCore` | 包引用 | 版本 `3.0.2` |
| `Microsoft.AspNetCore.WebUtilities` | 包引用 | 版本 `2.3.14` |
| `MySqlConnector` | 包引用 | 版本 `2.6.2` |
| `OrchardCore.Media.Azure` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ContentTypes.Abstractions` | 包引用 | 版本 `$(OrchardCoreVersion)` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | — | — | — | — | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：公共 API 见源码中文 XML 注释。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj"
dotnet test "src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj"
```

子项目各自含 Readme-CN.md。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
