# 使用方式

> 上级：[docs/Readme-CN.md](../docs/Readme-CN.md)

单表后台页访问 `/Admin/DataTable/{providerName}/{queryId?}`；可启用 Samples 查看演示。

实现 `IDataTableDataProvider` 并用 `AddDataTableDataProvider<T>()` 注册；前端 `smartent_DataTables`，事件命名空间 `.smartentdt`。

### 引用

```xml
<ProjectReference Include="src/Modules/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables/Smartent.Orchard.DataTables.csproj" />
```

### NuGet（发布后）

```xml
<PackageReference Include="Smartent.Orchard.DataTables" Version="1.0.0" />
```
