# Smartent.Core.Cli | Smartent Core Cli
> **中文说明**: [Readme-CN.md](Readme-CN.md)


> **状态 | Status**：已迁入 src（M2）  
> **路径 | Path**：`src/Platform/Core/Smartent.Core.Cli`

---

## 摘要 | Summary

**中文**：基于 [CliWrap](https://github.com/Tyrrrz/CliWrap) 的命令行封装与辅助类型，包含 `CliProgram`、`WhichAsync`、按操作系统解析可执行扩展名等；依赖 `Smartent.Core.Primitives`。

**English**: CliWrap-based command helpers (`CliProgram`, PATH lookup, OS-specific executable extensions); depends on `Smartent.Core.Primitives`.

---

## 主要类型 | Main types

| 中文 | English | 源文件 |
|------|---------|--------|
| 固定命令包装（如 `dotnet`） | Named command wrapper | `CliProgram.cs` |
| PATH 查找与专用 CLI 任务 | CliWrap utilities | `Helpers/CliWrapHelper.cs` |
| 可执行文件扩展名等 | OS helpers | `Helpers/OperatingSystemHelper.cs` |
| 启动 .NET 托管应用等扩展 | `Command` extensions | `Extensions/CommandExtensions.cs` |

更多背景见仓库内 [Helpful Libraries Readme](../../../../src/Libraries/Smartent.HelpfulLibraries/Readme.md)。

---

## 引用方式 | References

### Monorepo（开发 | Development）

```xml
<ProjectReference Include="..\..\..\..\src\Platform\Core\Smartent.Core.Cli\Smartent.Core.Cli.csproj" />
```

通常同时需要 `Smartent.Core.Primitives`。

### NuGet

`PackageId`：`Smartent.Core.Cli`（发布节奏见 M7）。

---

## 验证 | Verification

```powershell
dotnet build src/Platform/Core/Smartent.Core.Cli/Smartent.Core.Cli.csproj
```