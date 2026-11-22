# 子方案：Smartent.Core.Primitives（M2 完成�?

> 阶段：M2  
> 状态：**完成**（待 build/test 验证�?

## 范围

- �?`Lombiq.HelpfulLibraries.Common` 迁入 `Smartent-src/Platform/Core/Smartent.Core.Primitives`
- 删除 Legacy `src/.../Lombiq.HelpfulLibraries.Common`

## 命名

| �?| �?|
|----|-----|
| PackageId | `Smartent.Core.Primitives` |
| 根命名空�?| `Smartent.Core.Primitives.*`（含 Utilities、Extensions 子命名空间） |

## 引用已更�?

- `Lombiq.HelpfulLibraries.{AspNetCore,OrchardCore,Cli,}` 元包
- `Lombiq.VueJs.Samples`、`Lombiq.OrchardCoreApiClient.Tester`
- 全仓�?`using` / `@using` 由脚本替�?
- `Smartent.Orchard.sln` / `slnx`（原 `Lombiq.OSOCE.*`）、`Lombiq.HelpfulLibraries.sln` / `slnx`

## 遗留

- 部分公共 API 仍为 Lombiq 英文 XML；按 `docs/standards/csharp.md` 后续逐文件补中文�?
- `HelpfulLibraries.Tests` 仍位�?Legacy 路径，通过元包间接�?Primitives�?

## 验证命令

```powershell
dotnet build Smartent-src/Platform/Core/Smartent.Core.Primitives/Smartent.Core.Primitives.csproj
dotnet build src/Libraries/Lombiq.HelpfulLibraries/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj
dotnet test src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.Tests/Lombiq.HelpfulLibraries.Tests.csproj --filter "FullyQualifiedName~UnitTests.Utilities"
```