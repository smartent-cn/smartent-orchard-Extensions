# 子方案：M7 批次 #14（Legacy 发布面说明）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围

| Legacy | 说明 |
|--------|------|
| `src/Libraries/Lombiq.HelpfulLibraries` | 元包聚合；**不发布** Smartent 产品面，见 `Smartent-src/Platform/` |
| `src/Utilities/Lombiq.MSBuild.Targets` | Sdk **源码已迁**；本目录 Samples/Tests + 占位 Readme |
| `scripts/List-SmartentPackableProjects.ps1` | 与 `docs/releases/M7-FirstNuGet-Release-Draft.md` 对照 |

## 验证

```powershell
./scripts/List-SmartentPackableProjects.ps1 | Select-String Smartent
rg '<PackageId>Lombiq\.' Smartent-src --glob '*.csproj'  # 应无（Sdk 走目录名推断除外）
```