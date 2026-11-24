# Smartent.Test.OrchardCore

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Test/Smartent.Test.OrchardCore`

## 摘要

Smartent.Test.OrchardCore：Smartent Orchard Extensions 组件。Orchard Core 单元/集成测试辅助（Moq.AutoMock 等）。

## 功能说明

**实现**

- - Smartent Test OrchardCore：Orchard Core 单元/集成测试辅助（Moq.AutoMock 等）。

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="../../Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Test.OrchardCore" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`—`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 测试项目引用；通过 `TestConfiguration.json` 或环境变量 `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION` 配置。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Moq.AutoMock` | 包引用 | 版本 `4.0.3` |
| `MySqlConnector` | 包引用 | 版本 `2.6.2` |

### 前端（如适用）

规范：[frontend-dependencies](../../docs/standards/frontend-dependencies.md)。仅当本目录存在 `package.json` 时执行前端构建命令。

| npm 包 | 版本 | 用途 | 构建 |
|--------|------|------|------|
| | — | — | — | — | | | | |

## 升级与扩展

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：`Smartent.Test.UI.*` 下的测试扩展与配方。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。

## 测试

```powershell
dotnet build "src/Test/Smartent.Test.OrchardCore/Smartent.Test.OrchardCore.csproj"
dotnet test "src/Test/Smartent.Test.OrchardCore/Smartent.Test.OrchardCore.csproj"
```

UI 测试：在解决方案中筛选 `*.Tests.UI.csproj` 运行。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
