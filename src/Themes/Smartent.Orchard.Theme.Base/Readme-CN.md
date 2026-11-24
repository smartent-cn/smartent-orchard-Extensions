# Smartent.Orchard.Theme.Base (solution)

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Themes/Smartent.Orchard.Theme.Base`

## 摘要

本目录为 `Smartent.Orchard.Theme.Base` 解决方案根。中文细节见子项目 Readme-CN.md；英文总览见 [Readme.md](Readme.md)。

Smartent.Orchard.Theme.Base：Smartent Orchard Extensions 组件。Smartent Orchard Theme Base for Orchard Core (Sass)

## 功能说明

**实现**

- - 包含主模块及 Samples/Tests 子工程。
- Smartent Orchard Theme Base for Orchard Core (Sass)：Smartent Orchard Theme Base for Orchard Core (Sass)

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.Theme.Base (solution)" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`（见 Manifest / Module.cs）`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 启用主题功能并设为站点或后台主题。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `OrchardCore.Theme.Targets` | 包引用 | 版本 `3.0.1` |
| `Smartent.Build.NodeJs` | 包引用 | 版本 `3.0.1-alpha.2.nest-665` |
| `Smartent.Core.CodeGen.SourceGenerators` | 包引用 | 版本 `12.6.1-alpha.10.osoe-925` |
| `Smartent.Core.CodeGen.Attributes` | 包引用 | 版本 `12.6.1-alpha.10.osoe-925` |

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
dotnet build "src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.csproj"
dotnet test "src/Themes/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base/Smartent.Orchard.Theme.Base.csproj"
```

子项目各自含 Readme-CN.md。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
