# 子方案：M5 `Smartent.Orchard.EInvoice`

> 阶段：**M5**  
> 状态：**已迁入 src**（2026-11-22）

## 范围

| 原路径 | 新路径 |
|--------|--------|
| `src/Libraries/Lombiq.EInvoiceValidator/` | `src/Libraries/Smartent.Orchard.EInvoice/` |

`PackageId`：`Smartent.Orchard.EInvoice`（Sample/Benchmark/Tests 卫星工程同步改名）。

## Legacy 清理（迁一删一）

- `src/Libraries/Lombiq.EInvoiceValidator` 实现已删除，仅留 `Readme.md` 指向（git 删除已暂存）。
- 局部方案：`Smartent.Orchard.EInvoice.slnx`。

## 构建注意

- Node/LibMan：见 `Smartent.Orchard.EInvoice/Readme.md`（`.disable-libman` + npm）。

## 验证

- `dotnet test src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.Tests`（36/36）
- 主 sln 已含主包 + Tests/Sample/Benchmark