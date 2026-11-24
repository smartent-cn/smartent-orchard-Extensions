# Smartent.Orchard.TrainingDemo.Tests

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.Tests`

## 摘要

Smartent.Orchard.TrainingDemo.Tests：Smartent Orchard Extensions 组件。Smartent.Orchard.TrainingDemo.Tests

## 功能说明

**实现**

- - Smartent.Orchard.TrainingDemo.Tests：Smartent.Orchard.TrainingDemo.Tests

**不实现（边界）**

- - 仅测试用途，不进入生产部署。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Orchard.TrainingDemo.Tests" Version="1.0.0" />
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
| `Microsoft.Testing.Extensions.GitHubActionsReport` | 包引用 | 版本 `2.5.2` |
| `Microsoft.Testing.Extensions.HangDump` | 包引用 | 版本 `2.5.2` |
| `Microsoft.Testing.Extensions.TrxReport` | 包引用 | 版本 `2.5.2` |
| `Moq` | 包引用 | 版本 `4.21.0` |
| `Moq.AutoMock` | 包引用 | 版本 `4.0.3` |
| `Shouldly` | 包引用 | 版本 `4.3.0` |
| `xunit.v3` | 包引用 | 版本 `4.0.3` |

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
dotnet build "src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.Tests/Smartent.Orchard.TrainingDemo.Tests.csproj"
dotnet test "src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.Tests/Smartent.Orchard.TrainingDemo.Tests.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
