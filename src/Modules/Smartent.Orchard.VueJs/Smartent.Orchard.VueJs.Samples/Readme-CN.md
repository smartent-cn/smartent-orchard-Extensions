# Smartent.Orchard.VueJs.Samples

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.Samples`

## 摘要

Smartent.Orchard.VueJs.Samples：Smartent Orchard Extensions 组件。Smartent Orchard Vue.js module for Orchard Core - Samples

## 功能说明

**实现**

- - Smartent Orchard Vue.js module for Orchard Core - Samples：Smartent Orchard Vue.js module for Orchard Core - Samples

**不实现（边界）**

- - 仅演示内容与配方，不用于生产站点。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.VueJs.Samples" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`（见 Manifest / Module.cs）`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 与父模块一起在 `Smartent.Demo.Web` 或样例宿主中启用。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `OrchardCore.ContentFields` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Module.Targets` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.DisplayManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.ResourceManagement` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `SixLabors.ImageSharp` | 包引用 | 版本 `3.1.12` |
| `ZXing.Net.Bindings.ImageSharp.V3` | 包引用 | 版本 `0.16.20` |
| `Smartent.Build.NodeJs` | 包引用 | 版本 `3.0.0` |
| `Smartent.Core.Primitives` | 包引用 | 版本 `12.6.1-alpha.7.osoe-925` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | `eslint` | 8.47.0 | devDependencies | see package.json scripts |
| `eslint-config-airbnb-base` | 15.0.0 | devDependencies | see package.json scripts |
| `eslint-plugin-import` | 2.28.1 | devDependencies | see package.json scripts |
| `eslint-plugin-node` | 11.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-only-warn` | 1.1.0 | devDependencies | see package.json scripts |
| `eslint-plugin-promise` | 7.2.1 | devDependencies | see package.json scripts |
| `vue-qrcode-reader` | 5.7.3 | devDependencies | see package.json scripts | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：公共 API 见源码中文 XML 注释。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.Samples/Smartent.Orchard.VueJs.Samples.csproj"
dotnet test "src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.Samples/Smartent.Orchard.VueJs.Samples.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
