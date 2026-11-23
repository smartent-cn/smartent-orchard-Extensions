# 子方案：M7 批次 #22（Marketing 配置节 + 文档/CI 路径）

> 阶段：**M7 / M5**  
> 状态：**已完成**（2026-11-23）

## 范围（10 项）

| # | 项 | 说明 |
|---|-----|------|
| 1 | `MarketingConfigurationKeys` | `Smartent_Marketing` + `Lombiq_Marketing` 常量 |
| 2 | `ShellConfigurationMarketingExtensions` | 配置绑定优先 Smartent，回退 Legacy |
| 3 | Pirsch `Startup` + Maintenance | 使用扩展方法读配置节 |
| 4 | `appsettings.json` | Demo Web + NuGetVerify Web → `Smartent_Marketing` |
| 5 | Pirsch `Readme.md` | 示例 JSON 与兼容说明 |
| 6 | Marketing Tests.UI | OrchardCore 配置键路径 |
| 7 | `AssetLinting.md` | 示例路径 `Smartent-src/` |
| 8 | 根 `Readme.md` | Themes/Utilities/Samples 指向 Smartent 包与路径 |
| 9 | `docs/migration/Configuration-Key-Rename.md` + Gitee NuGet 示例 | 配置键对照；`Smartent.Build.Analyzers.*` mapping |
| 10 | 门禁 | `Invoke-M7CoreFeedGate.ps1 -SkipPack` + `Smartent.Orchard.sln` Release |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack
dotnet build Smartent.Orchard.sln -c Release
```

## 下一批建议

→ **M7 批次 #23**（`M7-Batch-23-TrainingDemo-Docs-Ci.md`）。