# Smartent.Orchard.Http.Refit

> **状态 | Status**：已迁入 Smartent-src（M3）  
> **路径 | Path**：`Smartent-src/Platform/Orchard/Smartent.Orchard.Http.Refit`

---

## 摘要 | Summary

**中文**：基于 [Refit](https://github.com/reactiveui/refit) 的 HTTP API 客户端辅助（如 `RefitHelper`、`SimpleTextResponse`）。原 `Lombiq.HelpfulLibraries.Refit`。

**English**: Refit HTTP client helpers for Orchard-related libraries and modules.

---

## 引用 | References

```xml
<ProjectReference Include="..\..\..\..\Smartent-src\Platform\Orchard\Smartent.Orchard.Http.Refit\Smartent.Orchard.Http.Refit.csproj" />
```

`PackageId`：`Smartent.Orchard.Http.Refit`

---

## 验证 | Verification

```powershell
dotnet build Smartent-src/Platform/Orchard/Smartent.Orchard.Http.Refit/Smartent.Orchard.Http.Refit.csproj
dotnet build src/Libraries/Lombiq.OrchardCoreApiClient/Lombiq.OrchardCoreApiClient/Lombiq.OrchardCoreApiClient.csproj
```