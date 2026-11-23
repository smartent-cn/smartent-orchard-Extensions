# 子方案：M7 批次 #13（全量 NuGetVerify pack 流程）

> 阶段：**M7**  
> 状态：**文档化**（2026-11-23）

## 前置

- 绿：`./scripts/Invoke-M7CoreFeedGate.ps1`
- 磁盘与时间：`-Full` 打包 `Smartent.Orchard.sln` 常 **>15 分钟**

## 步骤

```powershell
./scripts/Pack-SmartentLocalFeed.ps1 -WhatIf    # 预览 core 列表
./scripts/List-SmartentPackableProjects.ps1    # Smartent-src 可发布面
Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
./scripts/Build-NuGetVerify-WithLocalFeed.ps1  # 含 -Full pack
```

## 未决

- CI 是否在 `master` 上定时跑 `-Full`（资源 expensive）
- Web Recipe 缺包时对照 `feed-manifest.txt` 与 `List-SmartentPackableProjects.ps1`