# Smartent.Build.OrchardCore.Tests.Sdk

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Build/Smartent.Build.OrchardCore.Tests.Sdk`

## 摘要

Smartent.Build.OrchardCore.Tests.Sdk：Smartent Orchard Extensions 组件。Smartent MSBuild SDK - Unit Testing (Smartent.MSBuild.OrchardCore.Tests.Sdk)

## 功能说明

**实现**

- - Smartent MSBuild SDK - Unit Testing (Smartent.MSBuild.OrchardCore.Tests.Sdk)：Smartent MSBuild SDK - Unit Testing (Smartent.MSBuild.OrchardCore.Tests.Sdk)

**不实现（边界）**

- - 仅测试用途，不进入生产部署。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="src/Build/Smartent.Build.OrchardCore.Tests.Sdk/Smartent.Build.OrchardCore.Tests.Sdk.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Build.OrchardCore.Tests.Sdk" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`—`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 使用 `dotnet test` 运行本单元测试项目。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| — | — | 无直接 PackageReference（可能由中央版本管理） |

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
dotnet build "src/Build/Smartent.Build.OrchardCore.Tests.Sdk/Smartent.Build.OrchardCore.Tests.Sdk.csproj"
dotnet test "src/Build/Smartent.Build.OrchardCore.Tests.Sdk/Smartent.Build.OrchardCore.Tests.Sdk.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
