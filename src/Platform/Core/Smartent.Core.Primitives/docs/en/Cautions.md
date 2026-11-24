# Pitfalls & cautions

> Index: [README.md](README.md) · Gateway: [../README.md](../README.md)

### 中文

- **Orchard 版本**：本包 **不** 依赖 Orchard；仅需与仓库 `net10.0` / 中央包版本策略一致。
- **扩展点**：新增扩展类请放在与现有相同的文件夹（`Extensions`/`Utilities` 等），并遵守 [csharp 规范](../../../../docs/standards/csharp.md)（公共 API 中文 XML）。
- **Smartent 定制**：从 Smartent `HelpfulLibraries.Common` 迁入；后续拆包在 Platform 层其它项目中进行，**勿** 再向此包塞 Orchard 专用逻辑。

### English

No Orchard dependency. Extend via new static extension/utility types. Keep Orchard-specific code in `Smartent.Orchard.Platform.*` (future).

---
