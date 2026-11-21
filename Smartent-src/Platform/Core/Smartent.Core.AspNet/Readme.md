# Smartent.Core.AspNet | Smartent Core AspNet

> **状态 | Status**：已迁入 Smartent-src（M2）  
> **路径 | Path**：`Smartent-src/Platform/Core/Smartent.Core.AspNet`

---

## 摘要 | Summary

**中文**：面向 ASP.NET Core 的扩展库，含内容安全策略（CSP）、Mvc 绑定与筛选器、延迟任务中间件、本地化与 HTTP 扩展；依赖 `Smartent.Core.Primitives`。

**English**: ASP.NET Core helpers—CSP providers, MVC utilities, deferred-task middleware, localization and HTTP extensions; depends on `Smartent.Core.Primitives`.

---

## 功能说明 | Features

### 中文

- **Security**：`ContentSecurityPolicyDirectives`、多种 `IContentSecurityPolicyProvider`、`ConfigureSecurityDefaults`（见 `Docs/Security.md`）。
- **Mvc**：`JsonModelBinder`、`DevelopmentOnlyAttribute`、`FrontendException` 配套（见 `Docs/Mvc.md`、`Docs/Exceptions.md`）。
- **Middlewares**：`DeferredTaskMiddleware`（见 `Docs/Middlewares.md`）。
- **Extensions / Localization**：HTTP、配置、Cookie、ForwardedHeaders 等（见 `Docs/`）。
- **不实现**：Orchard 模块清单、YesSql、多租户 Shell（在 `Smartent.Orchard.Platform.*`）。

### English

CSP, MVC, middleware, extensions—see `Docs/`. No Orchard CMS features.

---

## 引用方式 | References

### Monorepo（开发 | Development）

```xml
<ProjectReference Include="..\..\..\..\Smartent-src\Platform\Core\Smartent.Core.AspNet\Smartent.Core.AspNet.csproj" />
```

通常同时需要 `Smartent.Core.Primitives`。

### NuGet（发布后 | When published）

```xml
<PackageReference Include="Smartent.Core.AspNet" Version="1.0.0" />
```

---

## 使用方式 | Usage

### 中文

1. 引用程序集后，在 `Startup` / `Program` 中调用 `ConfigureSecurityDefaults()` 或文档中的扩展方法注册 CSP。
2. Orchard 模块中注册自定义 `IContentSecurityPolicyProvider` 时，引用 `Smartent.Core.AspNet.Security` 命名空间。
3. Web 场景下用户可见错误优先使用 `FrontendException` 而非 `UserReadableException`。

### English

Register security defaults and CSP providers per `Docs/Security.md`; use `FrontendException` for web UX errors.

---

## 依赖说明 | Dependencies

| 依赖 | 类型 | 用途 |
|------|------|------|
| `Microsoft.AspNetCore.App` | FrameworkReference | ASP.NET Core 运行时 |
| `Smartent.Core.Primitives` | Project | 基础工具与异常类型 |

### 前端

本库定义 **CSP 指令** 与提供程序，不自带 npm 包；使用方的前端资源须在各自模块 Readme 中说明（见 `docs/standards/frontend-dependencies.md`）。

---

## 升级与扩展 | Upgrade & Extension

### 中文

- 新增 CSP Provider：实现 `IContentSecurityPolicyProvider` 并在 DI 中注册。
- 与 Orchard `ResourceManagement` 联用时，注意脚本 nonce/hash 与模块加载顺序。
- 自 Lombiq `HelpfulLibraries.AspNetCore` 迁入；命名空间 `Smartent.Core.AspNet.*`。

### English

Extend via new CSP providers and documented DI registration patterns.

---

## 测试 | Tests

```powershell
dotnet build Smartent-src/Platform/Core/Smartent.Core.AspNet/Smartent.Core.AspNet.csproj
dotnet build src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.OrchardCore/Lombiq.HelpfulLibraries.OrchardCore.csproj
```

相关单元/集成测试分散在 `Lombiq.HelpfulLibraries.Tests` 与依赖模块的测试中。

---

## 来源与许可 | Provenance & License

- 源自 Lombiq Helpful-Libraries / AspNetCore，MIT。  
- Smartent 衍生部分 Copyright © Smartent。