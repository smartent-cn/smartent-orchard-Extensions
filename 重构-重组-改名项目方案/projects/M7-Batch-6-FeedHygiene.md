# 子方案：M7 批次 #6（本地 feed 增补与 NodeJs 样例）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 范围

| 项 | 说明 |
|----|------|
| `scripts/Pack-SmartentLocalFeed.ps1` | 默认 core 列表含 Theme/Tests Sdk、`Smartent.Build.Npm.Targets`、`Smartent.Build.NodeJs` |
| `scripts/Build-NuGetVerify-WithLocalFeed.ps1` | `-CorePack` 仅打 core（**不能** 满足全 Web sln） |
| `Smartent.Build.NodeJs.Samples.NuGet` | 单体仓 `ProjectReference` → `Smartent.Build.NodeJs`；构建生成物 gitignore |
| `NuGetVerify/Readme.md` | Monorepo sln / `NuGet.config.local` 流程 |

## 验证

```powershell
dotnet build NuGetVerify/Smartent.NuGet.Monorepo.sln -c Release
./scripts/Pack-SmartentLocalFeed.ps1
```

## 后续

- 批次 #7：`scripts/Verify-SmartentLocalFeed.ps1`、全 sln 流程见 [M7-Batch-7-FullSlnValidation.md](M7-Batch-7-FullSlnValidation.md)

## 未决

- Gitee Packages + CI secret；全 sln 绿仍依赖 `-Full` pack