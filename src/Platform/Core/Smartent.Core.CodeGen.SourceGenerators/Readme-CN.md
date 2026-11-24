# Smartent.Core.CodeGen.SourceGenerators

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Platform/Core/Smartent.Core.CodeGen.SourceGenerators`

## 摘要

Smartent.Core.CodeGen.SourceGenerators：Smartent Orchard Extensions 组件。LibMan 资源版本与 JSON 常量等 Roslyn 源生成器。

## 功能说明

**实现**

- - Smartent Core CodeGen Source Generators：LibMan 资源版本与 JSON 常量等 Roslyn 源生成器。

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../Smartent.Core.CodeGen.Attributes/Smartent.Core.CodeGen.Attributes.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Core.CodeGen.SourceGenerators" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`—`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 作为类库引用；无需启用 Orchard 功能。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Microsoft.CodeAnalysis.CSharp` | 包引用 | 版本 `5.6.0` |
| `System.Text.Json` | 包引用 | 版本 `10.0.14` |
| `Microsoft.CodeAnalysis.Analyzers` | 包引用 | 版本 `5.9.0` |

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
dotnet build "src/Platform/Core/Smartent.Core.CodeGen.SourceGenerators/Smartent.Core.CodeGen.SourceGenerators.csproj"
dotnet test "src/Platform/Core/Smartent.Core.CodeGen.SourceGenerators/Smartent.Core.CodeGen.SourceGenerators.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
