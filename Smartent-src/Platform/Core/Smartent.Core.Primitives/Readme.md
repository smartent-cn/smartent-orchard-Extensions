# Smartent.Core.Primitives | Smartent Core Primitives

> **状态 | Status**：已迁入 Smartent-src（M2）  
> **路径 | Path**：`Smartent-src/Platform/Core/Smartent.Core.Primitives`

---

## 摘要 | Summary

**中文**：与 Orchard 无关的通用 .NET 基础库，提供集合/字符串/JSON/IO 扩展、DI 辅助、验证特性、工具类与 `UserReadableException` 等，供 Smartent 其它库与模块引用。

**English**: Orchard-agnostic .NET primitives—collection/string/JSON/IO extensions, DI helpers, validation attributes, utilities, and `UserReadableException` for other Smartent libraries and modules.

---

## 功能说明 | Features

### 中文

- **Extensions**：对 `System.*`、`Microsoft.Extensions.*` 的扩展方法（见 `Docs/Extensions.md`）。
- **Utilities**：HTML/JSON/XML、文化、文件系统、哈希、版本树等（见 `Docs/Utilities.md`）。
- **DependencyInjection**：`ServiceCollection` / `ServiceProvider` 辅助（见 `Docs/DependencyInjection.md`）。
- **Validation**：邮箱列表等验证（见 `Docs/Validation.md`）。
- **Exceptions**：面向终端用户的可读异常类型（见 `Docs/Exceptions.md`）。
- **不实现**：Orchard 内容模型、多租户 Shell、CMS 业务。

### English

- Extension methods, utilities, DI helpers, validation, user-facing exceptions (see `Docs/`).
- Does **not** include Orchard content, multi-tenancy, or CMS logic.

---

## 引用方式 | References

### Monorepo（开发 | Development）

```xml
<ProjectReference Include="..\..\..\..\Smartent-src\Platform\Core\Smartent.Core.Primitives\Smartent.Core.Primitives.csproj" />
```

（请按相对路径调整层级。）

### NuGet（发布后 | When published）

```xml
<PackageReference Include="Smartent.Core.Primitives" Version="1.0.0" />
```

版本号以 Smartent 正式发布为准。

---

## 使用方式 | Usage

### 中文

1. 在项目文件中添加上述 `ProjectReference`。
2. 按命名空间引用，例如 `using Smartent.Core.Primitives.Utilities;`、`using Smartent.Core.Primitives.DependencyInjection;`。
3. 许多扩展挂载在 BCL 命名空间（如 `System`、`Microsoft.Extensions.DependencyInjection`），引用本程序集后即可使用对应扩展方法。
4. 详细 API 见各 `Docs/*.md` 与源代码中的 XML 注释。

### English

Add the project or package reference, then import `Smartent.Core.Primitives.*` or rely on BCL-namespace extension methods documented under `Docs/`.

---

## 依赖说明 | Dependencies

### .NET（NuGet）

| 依赖 | 用途 |
|------|------|
| AngleSharp | HTML 解析与处理 |
| Microsoft.Extensions.Caching.Memory | 内存缓存扩展 |
| Microsoft.Extensions.Configuration.Binder | 配置绑定扩展 |

### 前端

无 `package.json`；不适用前端依赖专节。

---

## 升级与扩展 | Upgrade & Extension

### 中文

- **Orchard 版本**：本包 **不** 依赖 Orchard；仅需与仓库 `net10.0` / 中央包版本策略一致。
- **扩展点**：新增扩展类请放在与现有相同的文件夹（`Extensions`/`Utilities` 等），并遵守 [csharp 规范](../../../../docs/standards/csharp.md)（公共 API 中文 XML）。
- **Smartent 定制**：从 Lombiq `HelpfulLibraries.Common` 迁入；后续拆包在 Platform 层其它项目中进行，**勿** 再向此包塞 Orchard 专用逻辑。

### English

No Orchard dependency. Extend via new static extension/utility types. Keep Orchard-specific code in `Smartent.Orchard.Platform.*` (future).

---

## 测试 | Tests

```powershell
dotnet build Smartent-src/Platform/Core/Smartent.Core.Primitives/Smartent.Core.Primitives.csproj
dotnet test Smartent-src/Test/Smartent.Test.Platform/Smartent.Test.Platform.csproj --filter "FullyQualifiedName~UnitTests.Utilities"
```

（单元测试在 `Smartent.Test.Platform`，覆盖 VersionTree、HtmlHelper 等。）

---

## 来源与许可 | Provenance & License

- 源自 Lombiq [Helpful-Libraries / Common](https://github.com/Lombiq/Helpful-Libraries)，MIT。
- Smartent 衍生部分 Copyright © Smartent。