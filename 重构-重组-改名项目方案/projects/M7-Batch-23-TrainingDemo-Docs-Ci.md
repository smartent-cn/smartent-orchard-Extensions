# 子方案：M7 批次 #23（TrainingDemo 配置 + 模块索引 + CI 文档）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围（10 项）

| # | 项 | 说明 |
|---|-----|------|
| 1 | `TrainingDemoConfigurationKeys` | `Smartent_TrainingDemo` + `Lombiq_TrainingDemo` |
| 2 | `ShellConfigurationTrainingDemoExtensions` | 配置节回退 |
| 3 | TrainingDemo `Startup` | `GetTrainingDemoSection()` |
| 4 | Demo `appsettings.json` | `Smartent_TrainingDemo` |
| 5 | `Configuration-Key-Rename.md` | TrainingDemo 行 |
| 6 | `src/Modules/README.md` | 中英模块索引表 |
| 7 | 根 `Readme.md` | Modules 段指向 Smartent-src 索引 |
| 8 | `docs/ci/Smartent-GitHub-Actions.md` | GHA 迁移动机与步骤 |
| 9 | `.github/YAMLLinting.md` + `build-and-test.yml` 注释 | 指向 Smartent GHA 文档 |
| 10 | 门禁 + **git commit**（含 #20–#23 累积变更） |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack
dotnet build Smartent.Orchard.sln -c Release
```

## 下一批建议

- `Lombiq_Hosting_*` 配置节批量 Smartent 化（Hosting.Tenants / ApplicationInsights）
- 根 CI `uses: Lombiq/GitHub-Actions` → 发布 `smartent-cn/Smartent.GitHub.Actions` 后改引用
- 根 `Readme.md` Libraries 段 Smartent 索引