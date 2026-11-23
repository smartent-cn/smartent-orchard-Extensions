# 子方案：M7 批次 #18（Legacy batch 3–5 后文档与门禁）

> 阶段：**M5 Legacy 收尾 / M7**  
> 状态：**已完成**（2026-11-24）

## 范围（10 项）

| # | 项 | 说明 |
|---|-----|------|
| 1 | `M6-PackageId-Exceptions.md` | 复检日期；Legacy 无待发布 csproj |
| 2 | `M7-Batch-14-LegacyPublishSurface.md` | 元包已删；MSBuild shim |
| 3 | `M7-Batch-NuGetVerify-Feed.md` | `Smartent.Build.Targets.Tests` 路径 |
| 4 | `M4-MSBuild-Targets.md` | 验证命令 Smartent 路径 |
| 5 | `阶段检查表.md` | M3 元包 csproj 已删 |
| 6 | `项目清单.md` | Layer 3 MSBuild 行 |
| 7 | `Smartent.Build.LibMan.Targets/Readme.md` | 示例 Import / 包 ID |
| 8 | `Lombiq.MSBuild.Targets.slnx` | 注册 Samples/Tests/NuGet.Samples |
| 9 | `Invoke-M7CoreFeedGate.ps1` | 末尾 `Smartent.Build.Targets.Tests` |
| 10 | `docs/migration/Legacy-to-Smartent-src-Mapping.md` | 与 batch 3–5 一致（上轮已更） |

## 验证

```powershell
./scripts/Invoke-M7CoreFeedGate.ps1 -SkipPack
dotnet test Smartent-src/Build/Smartent.Build.Targets.Tests/Smartent.Build.Targets.Tests.csproj -c Release
```

## 下一批建议

- `Invoke-M7FullNuGetVerifyGate.ps1`（夜间 `-Full` pack）
- `M7#10` Gitee push（凭据就绪时）
- ~~`tools/Lombiq.Analyzers*`~~ → `tools/Smartent.Build.Analyzers*`（已完成）