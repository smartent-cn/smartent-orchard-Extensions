# Orchard 模块文档规范 | Module documentation

`src/Modules/**` 下**每个模块家族**（解决方案根目录）与**可发布的模块 csproj 目录**应使用加厚模板：

| 文件 | 语言 |
|------|------|
| `Readme.md` | English |
| `Readme-CN.md` | 中文 |

模板：

- [MODULE_README.en.template.md](../templates/MODULE_README.en.template.md)
- [MODULE_README.cn.template.md](../templates/MODULE_README.cn.template.md)

必备章节：**适用场景、快速开始、Feature 表、配置、管理员用法、开发者用法、样例/Recipe、注意事项、测试**。

批量从 Manifest/Recipe/配置类提取骨架后运行：

```powershell
python scripts/Thicken-ModuleReadmes.py
```

生成后须人工校对业务表述；复杂模块（DataTables、VueJs、Hosting.Tenants）在自动骨架上继续加厚子项目文档。