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
| 5b | `NodeJs` / `Tailwind` / `SetupExtensions` | `Smartent.Build.NodeJs`、`Smartent.Build.Tailwind`、`Smartent.Orchard.Setup` | **已完成**（`LoadExecWithMutexTask.targets` → `Smartent.Build.NodeJs.dll`） |
| 6 | Sdk 包发布与 `NuGetTest` 去 `Lombiq.HelpfulLibraries.OrchardCore` 中央版本 | 新 Sdk 版本上源 | **单体仓内已完成**（独立 NuGetTest 仍待发布 Sdk） |
| 7 | Tailwind Samples/Tests 迁入 `Smartent-src/Build/` | — | **已完成** |
| 8 | `Lombiq.OrchardCoreApiClient` → `Smartent.Orchard.ApiClient` | — | **已完成** |
| 9 | MSBuild.Targets 发布元数据 Smartent 化（PackageId 仍 Lombiq.MSBuild.*） | — | **首期完成**（含 `Lombiq.MSBuild.Library.Sdk` 重复 Title 修复） |
| 10 | 根 ESLint/Prettier/Stylelint | 指向 `Smartent.Build.NodeJs/config/`；Legacy 占位 | **已完成** |
| 11 | 主 sln Release 构建门禁 | VueJs `.nx`、`lint-code.js`、Tests.UI net10 | **已完成** |

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
dotnet build src/Modules/Lombiq.OSOCE.Samples/Lombiq.OSOCE.Samples.csproj
dotnet test src/Utilities/Lombiq.MSBuild.Targets/Lombiq.MSBuild.Targets.Tests/Lombiq.MSBuild.Targets.Tests.csproj --filter "FullyQualifiedName~SdkTests"
```

## 修订

| 版本 | 日期 | 说明 |
|------|------|------|
| 1.0 | 2026-11-22 | M3 Platform 收口后启动 M4；首项 Orchard Module Sdk |
| 1.1 | 2026-11-22 | Sdk 路径/LibMan/Test.Sdk；NuGetTest 单体仓 Module.Sdk |
| 1.2 | 2026-11-22 | 迁入 `Smartent.Build.Npm.Targets`；NuGetTest 本地 Module.Sdk |
| 1.3 | 2026-11-22 | 迁入 NodeJs / Tailwind / Setup；主 sln 去元包 |
| 1.4 | 2026-11-22 | M4#10–#11：根前端配置、`lint-code.js`、Release sln 绿 |