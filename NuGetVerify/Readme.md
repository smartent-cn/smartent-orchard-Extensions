# NuGet 发布验证 | NuGet publish smoke tests

**中文**：独立解决方案，用于验证从 NuGet 源安装的包。

- **前**（Web / 单测）：显式 `Smartent.*` 包引用，已去掉 `Lombiq.HelpfulLibraries` 元包。  
- **后**（模块 Sdk）：**本 monorepo** 内 `UseSmartentMonorepoMsBuildSdk` 引用 `src/Build/Smartent.Build.*`；独立还原时用 **`Smartent.Build.*` 2.1.1**（本地 feed，`PackageType=MSBuildSdk`）。`ForceStandaloneNuGetVerify` 在单体仓内仍走仓库 Sdk Import + 产品包 feed 还原。  
- **CI**：`Smartent.NuGet.Monorepo.sln`（无 Web / Tests.UI）。  
- **全量仅 PackageReference**：复制 `NuGet.config.local.example` → `NuGet.config.local`，在仓库根执行 `scripts/Build-NuGetVerify-WithLocalFeed.ps1`（默认 `-Full` pack；`-CorePack` 仅打核心包，不足以构建 Web）。

**English**: Standalone solution to smoke-test packages restored from NuGet feeds. Module/theme/Web package IDs use **`Smartent.*`** (see [M7-Batch-NuGetTest-PackageIds.md](../重构-重组-改名项目方案/projects/M7-Batch-NuGetTest-PackageIds.md)).

| 解决方案 | 用途 |
|----------|------|
| `Smartent.NuGet.Monorepo.sln` | CI / monorepo：Module·Theme·Tests·NodeJs（无 Web / Tests.UI） |
| `Smartent.NuGet.sln` | Full PackageReference verification (local feed or Gitee Packages) |

```powershell
# Monorepo CI 等价
dotnet build NuGetVerify/Smartent.NuGet.Monorepo.sln -c Release

# Core 本地 feed 冒烟（推荐单命令）
./scripts/Invoke-M7CoreFeedGate.ps1
# 或分步：
./scripts/Pack-SmartentLocalFeed.ps1
./scripts/Verify-SmartentLocalFeed.ps1
./scripts/Test-NuGetVerifyCorePackageRestore.ps1

# 全量 sln（耗时长，需 -Full pack）
Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
./scripts/Build-NuGetVerify-WithLocalFeed.ps1
```

独立检出：平台与测试基础设施从 **SmartentLocal**；`Smartent.Build.Analyzers` / `Smartent.Build.Analyzers.OrchardCore` 由 `Pack-SmartentLocalFeed.ps1` 写入本地 feed（见 `scripts/feed-core-pack-versions.ps1`）。

See also [M3-HelpfulLibraries-MetaPackage.md](../重构-重组-改名项目方案/projects/M3-HelpfulLibraries-MetaPackage.md) and [scripts/README.md](../scripts/README.md).