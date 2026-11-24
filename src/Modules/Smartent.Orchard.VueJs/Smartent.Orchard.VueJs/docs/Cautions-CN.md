# 注意事项与常见坑

> 上级：[docs/Readme-CN.md](Readme-CN.md)

- 修改脚本后需先跑 Node/pnpm 再 `dotnet build`。
- CSP 可能阻止 Vue 内联初始化；与平台 CSP 模块对齐。
