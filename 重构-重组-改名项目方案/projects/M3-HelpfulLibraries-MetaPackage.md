# 子方案：M3 元包 `Lombiq.HelpfulLibraries`

> 阶段：**M3**（第 5 项）  
> 状态：**基本完成**（元包仍保留于 sln 供 Legacy 打包；无工程 ProjectReference）

## 目标

- 过渡期保留 `Lombiq.HelpfulLibraries` 聚合 csproj，**仅**用于兼容测试与 NuGet 冒烟；不再作为新模块的默认依赖。
- 发布侧逐步改为引用各 `Smartent.*` 包（见 `Smartent-src/Platform/`）。
- 终态：元包 **废弃** 或替换为 `Smartent.Platform` 聚合包（可选，非本步必须）。

## 现状（2026-11-22）

| 消费者 | 引用方式 | 处理 |
|--------|----------|------|
| `Lombiq.HelpfulLibraries.Tests` | ProjectReference 元包 | **已改**为直接 Smartent ProjectReference |
| `Lombiq.OSOCE.Samples` | ProjectReference 元包 | **改**为直接 Smartent ProjectReference |
| `NuGetTest` | PackageReference NuGet | 待 Smartent 包发布后改 `PackageReference` |
| 新模块 | — | **禁止**（见总纲 `重构-重组-改名项目方案/Readme.md` §5.2） |

元包内 `ProjectReference` 已全部指向 `Smartent-src`（Core + Orchard Platform）。

## 步骤

1. [x] 元包工程路径仍 Legacy，引用 Smartent 子包。
2. [x] `Lombiq.OSOCE.Samples` 改为显式 Smartent 引用并验证 `dotnet build`。
3. [x] 元包 `DescriptionBody` / 文档标明 **Deprecated for new code**。
4. [x] NuGetTest **前**：Web / Tests → `Smartent.*`；**后**：保留 `Lombiq.HelpfulLibraries.OrchardCore` 中央版本供旧 Module.Sdk 2.1.1。
5. [ ] 评估是否从 `Smartent.Orchard.sln` 移除元包项目（仅当无工程引用）。

## 验证

```powershell
dotnet build src/Modules/Lombiq.OSOCE.Samples/Lombiq.OSOCE.Samples.csproj
dotnet build src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.csproj
dotnet test src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.Tests/Lombiq.HelpfulLibraries.Tests.csproj --filter "FullyQualifiedName~UnitTests"
```