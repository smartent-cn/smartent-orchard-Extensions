# Smartent GitHub Actions 迁移说明

> **中文**：可复用工作流源码在 `tools/Smartent.GitHub.Actions/`。根目录 `.github/workflows/*.yml` 当前仍 **调用** `Lombiq/GitHub-Actions@dev`，待独立发布后再切换。  
> **English**: Reusable workflow sources live under `tools/Smartent.GitHub.Actions/`; root CI still pins Lombiq until `smartent-cn/Smartent.GitHub.Actions` is published.

## 当前状态 | Current state

| 工作流 | 位置 | 说明 |
|--------|------|------|
| Build / test Orchard | `.github/workflows/build-and-test*.yml` | `uses: Lombiq/GitHub-Actions/...` |
| M7 feed 冒烟 | `.github/workflows/smartent-local-feed-smoke.yml` | **本仓库原生**脚本 `Invoke-M7CoreFeedGate.ps1` |
| 可复用工作流全集 | `tools/Smartent.GitHub.Actions/.github/workflows/` | 与 Lombiq 上游同结构，PackageId 已 Smartent 化 |

GitHub 要求可复用工作流 YAML 位于某仓库的 **`.github/workflows/`**；不能直接 `uses: .../tools/Smartent.GitHub.Actions/...`。

## 切换到 Smartent 引用前的准备 | Before switching `uses:`

1. 将 `tools/Smartent.GitHub.Actions` 推送到 **`smartent-cn/Smartent.GitHub.Actions`**（独立仓库或镜像），默认分支含 `.github/workflows/*`。  
2. 在 GitHub 配置 Secrets（见根目录 [`github-gitee-相关信息.md`](../../github-gitee-相关信息.md) NuGet / CI 章节）。  
3. 把根 workflow 中的  
   `Lombiq/GitHub-Actions/.github/workflows/....yml@dev`  
   改为  
   `smartent-cn/Smartent.GitHub.Actions/.github/workflows/....yml@<tag>`。  
4. `Lombiq/PowerShell-Analyzers` 同理，待 Smartent 侧发布或继续沿用 Lombiq 直至迁移。  
5. PR 验证：fork 上跑 `build-and-test` + `smartent-local-feed-smoke`。

## 本地对照文档 | Local docs

- `tools/Smartent.GitHub.Actions/Docs/Workflows/Productivity/PublishNuGetPackage.md`
- `tools/Smartent.GitHub.Actions/Docs/Workflows/Productivity/AssetLinting.md`（示例路径已用 `Smartent-src/`）