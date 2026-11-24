# Smartent.Test.Platform | Smartent 平台层测试
> **中文说明**: [Readme-CN.md](Readme-CN.md)


**中文**：覆盖 `Smartent.Core.*` 与 `Smartent.Orchard.Platform.*` 的 xUnit 用例（原 `Smartent.HelpfulLibraries.Tests`）。

**English**: xUnit tests for Smartent Core and Orchard Platform packages (formerly Smartent HelpfulLibraries.Tests).

## 运行 | Run

```powershell
dotnet test src/Test/Smartent.Test.Platform/Smartent.Test.Platform.csproj --filter "FullyQualifiedName~UnitTests"
```

## 引用 | References

直接 `ProjectReference` 各 Platform 子包（非元包）。
Direct project references to Platform packages (not the legacy meta-package).