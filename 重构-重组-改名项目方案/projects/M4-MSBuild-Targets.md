# 子方案：M4 Build / MSBuild Targets

> 阶段：**M4**  
> 状态：**实施中**（2026-11-22）

## 范围

`src/Utilities/Lombiq.MSBuild.Targets` 及关联 Npm/Node/Tailwind/Setup，逐步 Smartent 化；终态目录目标 `Smartent-src/Build/`（迁一删一，未迁前仍在 Legacy 路径）。

| 顺序 | 现路径 | 目标（草案） | 状态 |
|------|--------|-------------|------|
| 1 | `Lombiq.MSBuild.OrchardCore.Module.Sdk` | 默认依赖 `Smartent.Orchard.Platform`（NuGet + monorepo ProjectReference） | **已完成** |
| 2 | `Lombiq.MSBuild.OrchardCore.Theme.Sdk` | 不注入 Platform（主题按需引用模块/BaseTheme） | **不适用** |
| 3 | `Lombiq.MSBuild.Base.Sdk` | `SmartentSrcPath`、`PackageVersionSmartentPlatform` | **已完成** |
| 4 | `Lombiq.MSBuild.LibMan.Targets` | Smartent CodeGen；移除无用 `LombiqHelpfulLibrariesPath` | **已完成** |
| 4b | OrchardCore.Tests*.Sdk | `LombiqSolutionRootPath` 路径 `/` 规范化 | **已完成** |
| 5a | `Lombiq.Npm.Targets` | `Smartent.Build.Npm.Targets` | **已完成** |
| 5b | `NodeJs` / `Tailwind` / `SetupExtensions` | `Smartent.Build.*` | 待办 |
| 6 | Sdk 包发布与 `NuGetTest` 去 `Lombiq.HelpfulLibraries.OrchardCore` 中央版本 | 新 Sdk 版本上源 | **单体仓内已完成**（独立 NuGetTest 仍待发布 Sdk） |

## M4#1 / #3 首期交付

- Module.Sdk：`PackageReference` = `Smartent.Orchard.Platform`；monorepo `ProjectReference` 路径使用 `$(LombiqSolutionRootPath)/Smartent-src/...`（避免路径拼接缺斜杠）。
- Base.Sdk：声明 `SmartentSrcPath` 指向仓库 `Smartent-src/`（相对解决方案根）。

## 验证

```powershell
dotnet build src/Modules/Lombiq.TrainingDemo/Lombiq.TrainingDemo/Lombiq.TrainingDemo.csproj
dotnet build src/Modules/Lombiq.OSOCE.Samples/Lombiq.OSOCE.Samples.csproj
dotnet test src/Utilities/Lombiq.MSBuild.Targets/Lombiq.MSBuild.Targets.Tests/Lombiq.MSBuild.Targets.Tests.csproj --filter "FullyQualifiedName~SdkTests"
```

## 修订

| 版本 | 日期 | 说明 |
|------|------|------|
| 1.0 | 2026-11-22 | M3 Platform 收口后启动 M4；首项 Orchard Module Sdk |
| 1.1 | 2026-11-22 | Sdk 路径/LibMan/Test.Sdk；NuGetTest 单体仓 Module.Sdk |
| 1.2 | 2026-11-22 | 迁入 `Smartent.Build.Npm.Targets`；NuGetTest 本地 Module.Sdk |