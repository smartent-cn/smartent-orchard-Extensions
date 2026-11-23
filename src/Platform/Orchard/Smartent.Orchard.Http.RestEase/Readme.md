# Smartent.Orchard.Http.RestEase

## 功能 | Purpose

为 Orchard Core 应用提供 RestEase 类型化 HTTP 客户端注册扩展（遗留兼容；新代码建议使用 `Smartent.Orchard.Http.Refit`）。

## 引用 | References

Monorepo：

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Orchard\Smartent.Orchard.Http.RestEase\Smartent.Orchard.Http.RestEase.csproj" />
```

NuGet（M7 发布后）：

```xml
<PackageReference Include="Smartent.Orchard.Http.RestEase" Version="1.0.0" />
```

## 测试 | Tests

```powershell
dotnet build src/Platform/Orchard/Smartent.Orchard.Http.RestEase/Smartent.Orchard.Http.RestEase.csproj
```

---

English: RestEase HTTP client DI helpers for Orchard; prefer Refit for new code. Build with `dotnet build` on the csproj above.