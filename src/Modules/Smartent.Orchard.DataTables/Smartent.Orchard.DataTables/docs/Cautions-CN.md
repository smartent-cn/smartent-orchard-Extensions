# 注意事项与常见坑

> 上级：[docs/Readme-CN.md](Readme-CN.md)

- 索引型 Provider 需配方/迁移重建索引。
- 重查询优先用 `IndexBasedDataTableDataProvider`，避免按需全表扫描。
