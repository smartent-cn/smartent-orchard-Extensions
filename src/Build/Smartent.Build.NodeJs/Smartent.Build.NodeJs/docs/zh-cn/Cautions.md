# 注意事项与常见坑

> 索引：[README.md](README.md) · 入口：[../Readme-CN.md](../Readme-CN.md)

- **Orchard**：与仓库 `OrchardCoreVersion` / 中央包管理对齐。
- **扩展点**：Sdk 与 `build/*.targets` 中的 MSBuild 扩展点。
- **定制**：配置节使用 `Smartent_*` / `Smartent_Orchard_*`；本 demo 仓库 **不** 读取遗留 `Lombiq_*` 节。
