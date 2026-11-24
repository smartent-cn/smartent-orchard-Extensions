# Smartent.Orchard.Http.Refit
> **中文说明**: [Readme-CN.md](Readme-CN.md)


> **状态 | Status**：已迁入 src（M3）  
> **路径 | Path**：`src/Platform/Orchard/Smartent.Orchard.Http.Refit`

---

## 摘要 | Summary

**中文**：基于 [Refit](https://github.com/reactiveui/refit) 的 HTTP API 客户端辅助（如 `RefitHelper`、`SimpleTextResponse`）。原 `Smartent.HelpfulLibraries.Refit`。

**English**: Refit HTTP client helpers for Orchard-related libraries and modules.

---

## 引用 | References

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Orchard\Smartent.Orchard.Http.Refit\Smartent.Orchard.Http.Refit.csproj" />
```

`PackageId`：`Smartent.Orchard.Http.Refit`

---

## 验证 | Verification

```powershell
dotnet build src/Platform/Orchard/Smartent.Orchard.Http.Refit/Smartent.Orchard.Http.Refit.csproj
dotnet build src/Libraries/Smartent.OrchardCoreApiClient/Smartent.OrchardCoreApiClient/Smartent.OrchardCoreApiClient.csproj
```