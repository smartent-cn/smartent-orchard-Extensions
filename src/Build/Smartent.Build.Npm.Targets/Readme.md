# Smartent.Build.Npm.Targets

> **状态 | Status**：已迁入 src（M4）  
> **路径 | Path**：`src/Build/Smartent.Build.Npm.Targets`

---

## 摘要 | Summary

**中文**：构建前自动执行 `npm install` / `pnpm install` 与自定义 npm 脚本。原 `Smartent.Npm.Targets`。

**English**: MSBuild targets for npm/pnpm install and pre-build scripts. Formerly `Smartent.Npm.Targets`.

---

## 引用 | References

```xml
<Import Project="..\..\..\..\src\Build\Smartent.Build.Npm.Targets\Smartent.Build.Npm.Targets.props" />
<!-- … -->
<Import Project="..\..\..\..\src\Build\Smartent.Build.Npm.Targets\Smartent.Build.Npm.Targets.targets" />
```

NuGet：`PackageId` = `Smartent.Build.Npm.Targets`

---

## 验证 | Verification

```powershell
dotnet build src/Build/Smartent.Build.Npm.Targets/Smartent.Build.Npm.Targets.csproj
dotnet build src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj
```