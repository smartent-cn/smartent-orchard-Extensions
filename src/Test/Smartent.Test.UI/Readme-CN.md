# Smartent.Test.UI (solution)

> **状态**：培训/demo 单体仓库 · **English**: [Readme.md](Readme.md)  
> **路径**：`src/Test/Smartent.Test.UI`

## 摘要

本目录为 `Smartent.Test.UI` 解决方案根。中文细节见子项目 Readme-CN.md；英文总览见 [Readme.md](Readme.md)。

Smartent.Test.UI：Smartent Orchard Extensions 组件。Web UI testing toolbox mostly for Orchard Core applications. Everything you need to do UI testing with Selenium for an Orchard app is here.

## 功能说明

**实现**

- - 包含主模块及 Samples/Tests 子工程。
- Smartent UI Testing for Orchard Core：Web UI testing toolbox mostly for Orchard Core applications. Everything you need to do UI testing with Selenium for an Orchard app is here.

**不实现（边界）**

- - 除非文档说明，不替代 Orchard Core 内置能力。

## 引用方式

### Monorepo（开发）

```xml
<ProjectReference Include="Smartent.Test.UI/Smartent.Test.UI.csproj" />
```

### NuGet（发布后，版本号以实际发布为准）

```xml
<PackageReference Include="Smartent.Test.UI (solution)" Version="1.0.0" />
```

### Orchard 功能（如适用）

- 宿主中启用：`N/A`
- 相关模块：见「依赖说明」

## 使用方式

1. 在 Web 应用或模块解决方案中引用本项目。
2. 测试项目引用；通过 `TestConfiguration.json` 或环境变量 `SMARTENT_UI_TESTING_TOOLBOX_SHARED_TEST_CONFIGURATION` 配置。

## 依赖说明

### .NET / Orchard

| 依赖 | 类型 | 用途 |
|------|------|------|
| `AngleSharp.XPath` | 包引用 | 版本 `2.0.10` |
| `Atata` | 包引用 | 版本 `4.0.1` |
| `Atata.Bootstrap` | 包引用 | 版本 `4.0.0` |
| `Atata.HtmlValidation` | 包引用 | 版本 `4.0.0` |
| `Atata.WebDriverExtras` | 包引用 | 版本 `4.0.0` |
| `Atata.Xunit.v3` | 包引用 | 版本 `4.0.0` |
| `Azure.Storage.Blobs` | 包引用 | 版本 `12.30.1` |
| `Ben.Demystifier` | 包引用 | 版本 `0.4.1` |
| `Codeuctivity.ImageSharpCompare` | 包引用 | 版本 `4.1.390` |
| `Deque.AxeCore.Selenium` | 包引用 | 版本 `4.14.0` |
| `MailKit` | 包引用 | 版本 `4.18.2` |
| `Microsoft.Extensions.Diagnostics.Testing` | 包引用 | 版本 `10.11.0` |
| `Microsoft.SqlServer.DACFx` | 包引用 | 版本 `170.5.96` |
| `Microsoft.SqlServer.SqlManagementObjects` | 包引用 | 版本 `181.37.1` |
| `Mono.Posix.NETStandard` | 包引用 | 版本 `1.0.0` |
| `OrchardCore.Logging.NLog` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Recipes.Core` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `OrchardCore.Workflows` | 包引用 | 版本 `$(OrchardCoreVersion)` |
| `Sarif.Sdk` | 包引用 | 版本 `5.8.0` |
| `YamlDotNet` | 包引用 | 版本 `18.1.0` |
| `Smartent.Test.Unit` | 包引用 | 版本 `$(PackageVersionSmartentTests)` |
| `Smartent.Core.Cli` | 包引用 | 版本 `$(PackageVersionSmartentPlatform)` |
| `Smartent.Orchard.Platform` | 包引用 | 版本 `$(PackageVersionSmartentPlatform)` |
| `Smartent.Orchard.Http.Refit` | 包引用 | 版本 `$(PackageVersionSmartentPlatform)` |
| `HtmlSanitizer` | 包引用 | 版本 `9.2.1039` |

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
dotnet build "src/Test/Smartent.Test.UI/Smartent.Test.UI/Smartent.Test.UI.csproj"
dotnet test "src/Test/Smartent.Test.UI/Smartent.Test.UI/Smartent.Test.UI.csproj"
```

子项目各自含 Readme-CN.md。

## 来源与许可

- 自 Lombiq OSOCE 谱系迁入；已 Smartent 化包 ID 与命名空间。
- 许可：MIT（见仓库根 `License.md`）。
