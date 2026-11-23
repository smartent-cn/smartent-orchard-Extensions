# 子方案：M5 `Smartent.Orchard.TrainingDemo`

> 阶段：**M5**  
> 状态：**已迁入 src**（2026-11-22）

## 范围

| 原路径 | 新路径 |
|--------|--------|
| `src/Modules/Lombiq.TrainingDemo/` | `src/Modules/Smartent.Orchard.TrainingDemo/` |

子工程：`Smartent.Orchard.TrainingDemo`、`Smartent.Orchard.TrainingDemo.Tests`、`Smartent.Orchard.TrainingDemo.Web`（本地教学宿主，未入主 sln）。

## 破坏性变更（Feature Id）

 Orchard 模块 **Feature 标识** 已从 `Lombiq.TrainingDemo*` 改为 `Smartent.Orchard.TrainingDemo*`（含 `.Middlewares`、Workflow/Content Sample Recipe 名）。既有站点、旧 Recipe JSON、已启用功能列表 **不会** 自动迁移，需重新 Setup 或手工更新 Recipe。

| 原 Feature / Recipe | 新值 |
|---------------------|------|
| `Lombiq.TrainingDemo` | `Smartent.Orchard.TrainingDemo` |
| `Lombiq.TrainingDemo.Middlewares` | `Smartent.Orchard.TrainingDemo.Middlewares` |
| `Lombiq.TrainingDemo.Workflows.Sample` 等 | 对应 `Smartent.Orchard.TrainingDemo.*` |

已更新：`Smartent.Demo.Web` / `NuGetVerify` Recipe 中的启用列表（如适用）。

Manifest **显示名**仍为 Lombiq Training Demo（教学品牌保留）；`PackageId` = `Smartent.Orchard.TrainingDemo`。

## 验证

- `dotnet build`：`Smartent.Orchard.TrainingDemo`、`Smartent.Demo.Web`（Release）
- `dotnet test`：`Smartent.Orchard.TrainingDemo.Tests`（4/4）
- 主 sln：已移除 Legacy `src/Modules/Lombiq.TrainingDemo` 项；`Smartent.Orchard.slnx` 指向 Smartent-src

## 迁一删一

- Legacy `src/Modules/Lombiq.TrainingDemo` 实现已删除，仅留 `Readme.md` 指向说明。

## 未决

- 双语 `Readme.md` 全文化 Smartent 路径与 Feature 说明（当前头部仍为 Lombiq upstream 文案）