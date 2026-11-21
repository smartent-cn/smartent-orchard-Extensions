# 子方案：M3 Platform（HelpfulLibraries → Smartent.Orchard.Platform.*）

> 阶段：**M3**  
> 状态：**实施中**（2026-11-22）

## 范围

自 `src/Libraries/Lombiq.HelpfulLibraries/` 迁入 `Smartent-src/Platform/Orchard/`，命名空间与 PackageId 以 [项目清单](../项目清单.md) 为准。

| 顺序 | Legacy | 目标（草案） | 状态 |
|------|--------|-------------|------|
| 1 | `Lombiq.HelpfulLibraries.LinqToDb` | `Smartent.Orchard.Platform.Data.LinqToYesSql` | **已完成** |
| 2 | `Lombiq.HelpfulLibraries.Refit` | `Smartent.Orchard.Http.Refit` | 待办 |
| 3 | `Lombiq.HelpfulLibraries.OrchardCore.Testing` | `Smartent.Test.OrchardCore` | 待办 |
| 4 | `Lombiq.HelpfulLibraries.OrchardCore` | `Smartent.Orchard.Platform.*`（拆包 TBD） | 待办 |
| — | `Lombiq.HelpfulLibraries` 元包 | 废弃或仅文档指向各 Smartent 包 | 待办 |

## OrchardCore 大库

拆包决策在迁入 OrchardCore **之前** 定稿（Contents/Shell/Admin/Security/…）。本文件不替代该设计，仅约束：**Core 五包不得在 M3 回退到 Legacy 路径**。

## 验证（每迁一项）

```powershell
dotnet build Smartent-src/Platform/Orchard/<新项目>/<新项目>.csproj
dotnet build Lombiq.OSOCE.sln -c Debug --no-restore
```

相关测试随项目执行（如 DataTables 引用 LinqToDb 时补 build 下游）。

## 修订

| 版本 | 日期 | 说明 |
|------|------|------|
| 1.0 | 2026-11-22 | M2 收口后启动 M3；首项 LinqToDb |