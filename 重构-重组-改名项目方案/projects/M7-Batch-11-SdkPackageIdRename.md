# 子方案：M7 批次 #11（MSBuild Sdk PackageId Smartent 化）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23）

## 目标

将 `Smartent-src/Build/` 下已迁入 Sdk 的 **PackageId** 从 `Lombiq.MSBuild.*` 改为 `Smartent.Build.*`（或团队定名）。**仓库目录**已统一为 `Smartent.Build.*`（见插入批次：文件夹改名，PackageId 仍 Lombiq）。

## 建议顺序

1. `Lombiq.MSBuild.Base.Sdk` → `Smartent.Build.Base.Sdk`
2. `Lombiq.MSBuild.Library.Sdk`
3. `Lombiq.MSBuild.LibMan.Targets`
4. `Lombiq.MSBuild.OrchardCore.Module.Sdk` / Theme / Tests / Tests.UI.*
5. 全仓 `Sdk="Smartent.Build...` 与 `NuGetVerify` 中央版本
6. 更新 `feed-core-pack-versions.ps1`、`NuGet.config` mapping、`M6-PackageId-Exceptions.md`

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1
rg 'Lombiq\.MSBuild' NuGetVerify Smartent-src --glob '*.{csproj,props,md}'
```

## 前置

- 全量包清单：`./scripts/List-SmartentPackableProjects.ps1`
- 全 sln 验证手册：[M7-Batch-13-FullNuGetVerifyPack.md](M7-Batch-13-FullNuGetVerifyPack.md)

## 未决

- 是否与 Lombiq nuget.org 上旧 Sdk **二进制兼容**版本号策略
- 同时发布双 PackageId 过渡期（不推荐，除非有外部消费者）