# 子方案：M6 批次 #2（Platform 单测 + VueJs Legacy 清场）

> 阶段：**M6**  
> 状态：**已迁入 / 已清理**（2026-11-22）

## 范围

| 项 | 说明 |
|----|------|
| `Lombiq.HelpfulLibraries.Tests` | → `src/Test/Smartent.Test.Platform/` |
| `src/Modules/Lombiq.VueJs/` 残留副本 | 删除重复 `Lombiq.VueJs` / `Samples` 树，仅保留 `Readme.md` 指针 |

## 破坏性变更（摘要）

| 原 | 新 |
|----|-----|
| 命名空间 `Lombiq.HelpfulLibraries.Tests` | `Smartent.Test.Platform` |
| 测试 Feature Id 字符串（TypedRoute 等） | 同步为 `Smartent.Test.Platform` |

## 验证

```powershell
dotnet test src/Test/Smartent.Test.Platform/Smartent.Test.Platform.csproj --filter "FullyQualifiedName~UnitTests"
dotnet build Smartent.Orchard.sln -c Release
```

## 迁一删一

- `src/Libraries/Lombiq.HelpfulLibraries/Lombiq.HelpfulLibraries.Tests/` → 仅 `Readme.md`
- `src/Modules/Lombiq.VueJs/` → 仅 `Readme.md`

## 未决

- `Lombiq.MSBuild.*` Sdk 源码已迁至 `src/Build/`；`src/Utilities/Lombiq.MSBuild.Targets` 仅 Samples/Tests
- `tools/Smartent.Build.Analyzers*`（M1 目录已改名；包 Id 待定）
- `NuGetVerify` 独立还原（M7 Smartent 包上源后）