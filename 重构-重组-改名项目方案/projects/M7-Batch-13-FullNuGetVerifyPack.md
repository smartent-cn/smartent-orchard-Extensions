# 子方案：M7 批次 #13（全量 NuGetVerify pack 流程）

> 阶段：**M7**  
> 状态：**可验证**（2026-11-23；全 sln 本地绿）

## 前置

- 绿：`./scripts/Invoke-M7CoreFeedGate.ps1`
- 磁盘与时间：`-Full` 打包 `Smartent.Orchard.sln` 常 **>15 分钟**

## 步骤

```powershell
./scripts/Pack-SmartentLocalFeed.ps1 -WhatIf    # 预览 core 列表
./scripts/List-SmartentPackableProjects.ps1    # Smartent-src 可发布面
Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
./scripts/Build-NuGetVerify-WithLocalFeed.ps1  # -Full pack + supplemental + align + build
./scripts/Invoke-M7FullNuGetVerifyGate.ps1 -SkipPack  # 已有 feed 时重复验证
```

## 说明

- `-Full` 后会跑 **supplemental**（`feed-full-verify-supplemental.ps1`）与 **gap pack**（`Pack-NuGetVerifySupplementalGaps.ps1`），覆盖不在 `Smartent.Orchard.sln` 但 `Smartent.NuGet.Web` 引用的工程。
- `Align-NuGetVerifyVersionsToLocalFeed.ps1` 生成 `NuGetVerify/Directory.Packages.local.props`（gitignore），使中央版本与 feed 一致。

## 未决

- CI 是否在 `master` 上定时跑 `-Full`（资源 expensive）