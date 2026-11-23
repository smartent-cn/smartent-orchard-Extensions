# Smartent.Test.OrchardCore

> **状态 | Status**：已迁入 src（M3）  
> **路径 | Path**：`src/Test/Smartent.Test.OrchardCore`

---

## 摘要 | Summary

**中文**：Orchard Core 单元/集成测试辅助（如 `OrchardServicesExtensions`、Moq.AutoMock）。原 `Smartent.HelpfulLibraries.OrchardCore.Testing`。

**English**: Test helpers for Orchard Core apps (e.g. `OrchardServicesExtensions`, Moq.AutoMock). Formerly `Smartent.HelpfulLibraries.OrchardCore.Testing`.

---

## 引用 | References

```xml
<ProjectReference Include="..\..\..\..\src\Test\Smartent.Test.OrchardCore\Smartent.Test.OrchardCore.csproj" />
```

NuGet：`PackageId` = `Smartent.Test.OrchardCore`（依赖 `Smartent.Orchard.Platform`）。

---

## 验证 | Verification

```powershell
dotnet build src/Test/Smartent.Test.OrchardCore/Smartent.Test.OrchardCore.csproj
```