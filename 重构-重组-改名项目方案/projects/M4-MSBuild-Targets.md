# 子方案：M4 Build / MSBuild Targets

> 阶段：**M4**  
> 状态：**Sdk 迁入首期收口**（2026-11-23）；PackageId Smartent 化仍属 M7

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
| 5b | `NodeJs` / `Tailwind` / `SetupExtensions` | `Smartent.Build.NodeJs`、`Smartent.Build.Tailwind`、`Smartent.Orchard.Setup` | **已完成**（`LoadExecWithMutexTask.targets` → `Smartent.Build.NodeJs.dll`） |
| 6 | Sdk 包发布与 `NuGetVerify` 去 Lombiq 平台/测试中央版本 | SmartentLocal | **已完成**（M7#18–#19） |
| 7 | Tailwind Samples/Tests 迁入 `Smartent-src/Build/` | — | **已完成** |
| 8 | `Lombiq.OrchardCoreApiClient` → `Smartent.Orchard.ApiClient` | — | **已完成** |
| 9 | MSBuild.Targets 发布元数据 Smartent 化（PackageId 仍 Lombiq.MSBuild.*） | — | **首期完成**（含 `Lombiq.MSBuild.Library.Sdk` 重复 Title 修复） |
| 10 | 根 ESLint/Prettier/Stylelint | 指向 `Smartent.Build.NodeJs/config/`；Legacy 占位 | **已完成** |
| 11 | 主 sln Release 构建门禁 | VueJs `.nx`、`lint-code.js`、Tests.UI net10 | **已完成** |
| 12 | `Lombiq.MSBuild.Base.Sdk` 迁入 `Smartent-src/Build/` | 其余 Sdk 仍 Legacy；打包嵌入路径已更新 | **首期完成** |
| 13 | `Lombiq.MSBuild.LibMan.Targets` 迁入 `Smartent-src/Build/` | LibMan 路径、打包嵌入、CodeGen 版本属性 | **首期完成** |
| 14 | Sdk NuGet 样例 + `SdkTests` | 单体仓 pack 依赖 `Smartent.Orchard.Platform` | **首期完成** |
| 15 | `Lombiq.MSBuild.OrchardCore.Module.Sdk` 迁入 `Smartent-src/Build/` | Theme.Sdk 打包嵌入、全仓 monorepo Import 路径 | **首期完成** |
| 16 | `Lombiq.MSBuild.Library.Sdk` 迁入 `Smartent-src/Build/` | Platform/Core/库工程 monorepo 路径 | **首期完成** |
| 17 | `Lombiq.MSBuild.OrchardCore.Theme.Sdk` 迁入 `Smartent-src/Build/` | 主题/Test.AdminTheme；Theme 打包嵌入 Module.Sdk | **首期完成** |
| 18 | `Lombiq.MSBuild.OrchardCore.Tests.Sdk` 迁入 | 单元测试 / `Smartent.Test.Platform` 等 | **首期完成** |
| 19 | `Lombiq.MSBuild.OrchardCore.Tests.UI.*.Sdk` 迁入 | `Tests.UI.Sdk` 嵌入 Tests.Sdk；UI 库 Sdk | **首期完成** |
| 20 | Legacy `Lombiq.MSBuild.*` 占位 Readme | Base/LibMan/Module 及本批五 Sdk 迁一删一 | **首期完成** |
| 21 | `Lombiq.MSBuild.Sdk.Samples` 等 | Theme.Sdk `Smartent-src/Build` 路径 | **首期完成** |
| 22 | `Readme.md` / `UsingMSBuildSdks.md` | 指向 `Smartent-src/Build`；Legacy 仅占位 | **首期完成** |
| 23 | `dotnet pack` 冒烟 | Library + Theme + Module.Sdk nupkg | **首期完成** |
| 24 | `Lombiq.MSBuild.Targets.Tests` | SdkTests + LibManTests + Sdk.Samples 构建 | **首期完成** |
| 25 | Legacy 目录去重 | 非 git 跟踪的 Sdk 副本清理 | **首期完成** |

## M4#1 / #3 首期交付

- Module.Sdk：`PackageReference` = `Smartent.Orchard.Platform`；monorepo `ProjectReference` 路径使用 `$(LombiqSolutionRootPath)/Smartent-src/...`（避免路径拼接缺斜杠）。
- Base.Sdk：声明 `SmartentSrcPath` 指向仓库 `Smartent-src/`（相对解决方案根）。

## 根目录 / CI 前端配置（M4#10）

- 仓库根 `.eslintrc.js`、`.prettierrc.js`、`.stylelintrc.js` 已指向 `Smartent-src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/config/`。
- Legacy 占位：`src/Utilities/Lombiq.NodeJs.Extensions/Readme.md`。
- 消费方项目需通过 MSBuild `pnpm link` 链入 `nodejs-extensions` 后方可 `pnpm build`（勿在未 link 时单独跑 VueJs 脚本）。

## M4#11 Release 构建门禁

| 项 | 说明 |
|----|------|
| `scripts/lint-code.js` | 迁入 `Smartent.Build.NodeJs`；`overrideConfig` 使用 `parserOptions`（ESLint 8 / eslintrc，非 `languageOptions`） |
| VueJs helpers | `nx-scripts-path.js` 自 `helpers/` 向上解析 `node_modules/.nx/scripts`（含 `.lv` 拷贝消费路径） |
| SFC 构建 | `rollup-plugin-vue-sfc-orchard-core.js` 的 `overrideConfig` 使用 `overrides[].files` |
| Tests.UI | Atata 4 `PlainScopeLocator`、YesSql `IStore` 初始化重载；移除过时的 BiDi `SeleniumEntryExtensions` |
| 样例 / OSOCE UI | `Lombiq.OSOCE.Samples` Smartent 引用路径；`BehaviorVueTests` HtmlValidation / `ResponseLogFilters` |

```powershell
dotnet build Smartent.Orchard.sln -c Release
dotnet test Smartent-src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.Tests/Smartent.Orchard.EInvoice.Tests.csproj -c Release
dotnet test Smartent-src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.Tests/Smartent.Orchard.TrainingDemo.Tests.csproj -c Release
```

## 验证

```powershell
dotnet build Smartent-src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj
dotnet build Smartent-src/Demo/Smartent.Demo.Samples/Smartent.Demo.Samples.csproj -c Release
dotnet build Smartent-src/Build/Smartent.Build.Sdk.Samples/Smartent.Build.Sdk.Samples.csproj -c Release
dotnet test Smartent-src/Build/Smartent.Build.Targets.Tests/Smartent.Build.Targets.Tests.csproj -c Release
dotnet pack Smartent-src/Build/Smartent.Build.Library.Sdk/Smartent.Build.Library.Sdk.csproj -c Release
dotnet pack Smartent-src/Build/Smartent.Build.OrchardCore.Theme.Sdk/Smartent.Build.OrchardCore.Theme.Sdk.csproj -c Release
```

## 修订

| 版本 | 日期 | 说明 |
|------|------|------|
| 1.0 | 2026-11-22 | M3 Platform 收口后启动 M4；首项 Orchard Module Sdk |
| 1.1 | 2026-11-22 | Sdk 路径/LibMan/Test.Sdk；NuGetVerify 单体仓 Module.Sdk |
| 1.2 | 2026-11-22 | 迁入 `Smartent.Build.Npm.Targets`；NuGetVerify 本地 Module.Sdk |
| 1.3 | 2026-11-22 | 迁入 NodeJs / Tailwind / Setup；主 sln 去元包 |
| 1.4 | 2026-11-22 | M4#10–#11：根前端配置、`lint-code.js`、Release sln 绿 |