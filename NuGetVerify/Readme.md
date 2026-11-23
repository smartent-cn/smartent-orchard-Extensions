# NuGet 发布验证 | NuGet publish smoke tests

**中文**：独立解决方案，用于验证从 NuGet 源安装的包。

- **前**（Web / 单测）：显式 `Smartent.*` 包引用，已去掉 `Lombiq.HelpfulLibraries` 元包。  
- **后**（模块 Sdk）：在 **本 monorepo 内** 构建时 `UseSmartentMonorepoMsBuildSdk` 为 true，TestModule / TestTheme / Tests 引用仓库内 Sdk 与工程。独立检出 NuGetVerify 时仍用 nuget Sdk 2.1.1 + `Lombiq.HelpfulLibraries.OrchardCore`。  
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

# 全量 sln（耗时长，需本地 feed）
Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
./scripts/Build-NuGetVerify-WithLocalFeed.ps1
```

See also [M3-HelpfulLibraries-MetaPackage.md](../重构-重组-改名项目方案/projects/M3-HelpfulLibraries-MetaPackage.md) and [scripts/README.md](../scripts/README.md).