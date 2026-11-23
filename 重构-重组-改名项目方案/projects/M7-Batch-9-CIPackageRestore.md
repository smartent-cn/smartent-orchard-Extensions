# 子方案：M7 批次 #9（CI 与 PackageReference 还原冒烟）

> 阶段：**M7**  
> 状态：**已完成**（2026-11-23；聚合门禁见 `scripts/Invoke-M7CoreFeedGate.ps1`）

## 范围

| 项 | 说明 |
|----|------|
| `.github/workflows/smartent-local-feed-smoke.yml` | dev / 手动：core pack + verify + 独立还原冒烟 |
| `.github/workflows/build-and-test-windows.yml` | NuGet 作业 `Smartent.NuGet.Monorepo.sln` |
| `ForceStandaloneNuGetVerify` | 关闭 monorepo Sdk，测本地 feed 上的 `Smartent.*` |
| `Test-NuGetVerifyCorePackageRestore.ps1` | Tests / TestModule / TestTheme 独立 `dotnet restore` |
| `feed-core-pack-versions.ps1` | core pack 版本与 `NuGetVerify/Directory.Packages.props` 对齐 |
| `NuGetVerify/Directory.Packages.props` | 独立 Tests.Sdk：`Lombiq.Tests` 中央版本（M6 例外） |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1
```

## 未决

- 全 `Smartent.NuGet.sln`（Web）仍须 `-Full` pack
- Gitee 上与 GitHub Actions 等价 runner 配置