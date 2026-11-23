# 子方案：M7 批次 #14（Legacy 发布面说明）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-24，Legacy batch 3–5 后刷新）

## 范围

| Legacy | 说明 |
|--------|------|
| `src/Libraries/Lombiq.HelpfulLibraries` | **元包已删**；仅 Readme → `Smartent-src/Platform/` |
| `src/Utilities/Lombiq.MSBuild.Targets` | **shim**（`Directory.Build.props`）；Samples/Tests 在 `Smartent-src/Build/Smartent.Build.*` |
| `scripts/List-SmartentPackableProjects.ps1` | 与 `docs/releases/M7-FirstNuGet-Release-Draft.md` 对照 |

## 验证

```powershell
./scripts/List-SmartentPackableProjects.ps1 | Select-String Smartent
rg '<PackageId>Lombiq\.' Smartent-src --glob '*.csproj'  # 应无（Sdk 走目录名推断除外）
```