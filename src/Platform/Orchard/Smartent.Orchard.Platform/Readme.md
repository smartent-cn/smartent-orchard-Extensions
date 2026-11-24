# Smartent.Orchard.Platform
> **中文说明**: [Readme-CN.md](Readme-CN.md)


> **状态 | Status**：已迁入 src（M3，单包；`Smartent.Orchard.Platform.*` 垂直拆包 TBD）  
> **路径 | Path**：`src/Platform/Orchard/Smartent.Orchard.Platform`

---

## 摘要 | Summary

**中文**：Orchard Core 开发底座库（内容、MVC、资源、安全、工作流等）。原 `Smartent.HelpfulLibraries.OrchardCore`。命名空间为 `Smartent.Orchard.Platform.*`。

**English**: Orchard Core platform helpers (contents, MVC, resources, security, workflows, etc.). Formerly `Smartent.HelpfulLibraries.OrchardCore`; namespace `Smartent.Orchard.Platform.*`.

---

## 引用 | References

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Orchard\Smartent.Orchard.Platform\Smartent.Orchard.Platform.csproj" />
```

NuGet：`PackageId` = `Smartent.Orchard.Platform`

---

## 文档 | Documentation

专题说明见 [Docs/](Docs/)（沿用 Smartent 原文，标题逐步 Smartent 化）。

---

## 验证 | Verification

```powershell
dotnet build src/Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj
dotnet build src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj
```