# Smartent.Orchard.Platform.Data.LinqToYesSql

> **状态 | Status**：已迁入 src（M3）  
> **路径 | Path**：`src/Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql`

---

## 摘要 | Summary

**中文**：在 Orchard Core / YesSql 的 `ISession` 上通过 linq2db 写 LINQ 查询，替代手写 SQL。原 `Smartent.HelpfulLibraries.LinqToDb`。

**English**: LINQ-to-DB queries against YesSql `ISession` for Orchard Core (formerly Smartent Helpful Libraries LinqToDb).

---

## 用法 | Usage

- 使用 `LinqQueryAsync()` 等 `ISession` 扩展（见 `LinqToDbQueryExecutor.cs` 内联文档）。
- 样例：`src/Libraries/Smartent.HelpfulLibraries/Smartent.Demo.Platform.Samples/Controllers/LinqToDbSamplesController.cs`
- 自定义 SQL 方言：`Extensions/CustomSqlExtensions.cs`

---

## 引用 | References

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Orchard\Smartent.Orchard.Platform.Data.LinqToYesSql\Smartent.Orchard.Platform.Data.LinqToYesSql.csproj" />
```

`PackageId`：`Smartent.Orchard.Platform.Data.LinqToYesSql`

---

## 验证 | Verification

```powershell
dotnet build src/Platform/Orchard/Smartent.Orchard.Platform.Data.LinqToYesSql/Smartent.Orchard.Platform.Data.LinqToYesSql.csproj
dotnet build src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj
```