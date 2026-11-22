# 子方案：M3 Platform（HelpfulLibraries → Smartent.Orchard.Platform.*）

> 阶段：**M3**  
> 状态：**实施中**（2026-11-22）

## 范围

自 `src/Libraries/Lombiq.HelpfulLibraries/` 迁入 `Smartent-src/Platform/Orchard/`，命名空间与 PackageId 以 [项目清单](../项目清单.md) 为准。

| 顺序 | Legacy | 目标（草案） | 状态 |
|------|--------|-------------|------|
| 1 | `Lombiq.HelpfulLibraries.LinqToDb` | `Smartent.Orchard.Platform.Data.LinqToYesSql` | **已完成** |
| 2 | `Lombiq.HelpfulLibraries.Refit` | `Smartent.Orchard.Http.Refit` | **已完成** |
| 3 | `Lombiq.HelpfulLibraries.OrchardCore.Testing` | `Smartent.Test.OrchardCore` @ `Smartent-src/Test/` | **已完成** |
| 4 | `Lombiq.HelpfulLibraries.OrchardCore` | `Smartent.Orchard.Platform`（单包；`Smartent.Orchard.Platform.*` 拆包 TBD） | **已完成** |
| 5 | `Lombiq.HelpfulLibraries` 元包 | 废弃或仅文档指向各 Smartent 包 | **基本完成**（见 [M3-HelpfulLibraries-MetaPackage.md](M3-HelpfulLibraries-MetaPackage.md)） |

## OrchardCore 大库

垂直拆包（Contents/Shell/Admin/Security/…）在迁入后以子方案定稿；当前以**单包** `Smartent.Orchard.Platform` 交付。**Core 五包不得在 M3 回退到 Legacy 路径。**

## 验证（每迁一项）

```powershell
dotnet build Smartent.Orchard.sln -c Debug
dotnet build Smartent-src/Platform/Orchard/<新项目>/<新项目>.csproj
dotnet build Smartent-src/Test/Smartent.Test.OrchardCore/Smartent.Test.OrchardCore.csproj
dotnet build src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.csproj
dotnet test src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.Tests/Lombiq.HelpfulLibraries.Tests.csproj --filter "FullyQualifiedName~UnitTests"
```

相关测试随项目执行（含 DataTables 等引用 LinqToDb 时补 build 下游）。

## 修订

| 版本 | 日期 | 说明 |
|------|------|------|
| 1.0 | 2026-11-22 | M2 收口后启动 M3；首项 LinqToDb |
| 1.1 | 2026-11-22 | OrchardCore + Testing 迁入 Smartent.Orchard.Platform / Smartent.Test.OrchardCore |