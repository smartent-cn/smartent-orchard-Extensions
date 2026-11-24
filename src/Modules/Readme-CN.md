# Orchard 模块（`src/Modules`）

> **English**: [README.md](README.md)

本目录下每个文件夹对应一个 Orchard Core **模块家族**。均已按加厚模板撰写 **Readme.md（英文）** 与 **Readme-CN.md（中文）**，包含：适用场景、快速开始、Feature 表、配置、管理员/开发者用法、样例与 Recipe、注意事项、测试。

模板：[docs/templates/MODULE_README.cn.template.md](../../docs/templates/MODULE_README.cn.template.md)  
规范：[docs/standards/module-documentation.md](../../docs/standards/module-documentation.md)  
重新生成骨架：`python scripts/Thicken-ModuleReadmes.py`

| 序号 | 模块家族 | 英文 | 中文 |
|------|----------|------|------|
| 1 | AuditTrail | [Readme.md](Smartent.Orchard.AuditTrail/Readme.md) | [Readme-CN.md](Smartent.Orchard.AuditTrail/Readme-CN.md) |
| 2 | ChartJs | [Readme.md](Smartent.Orchard.ChartJs/Readme.md) | [Readme-CN.md](Smartent.Orchard.ChartJs/Readme-CN.md) |
| 3 | ContentEditors | [Readme.md](Smartent.Orchard.ContentEditors/Readme.md) | [Readme-CN.md](Smartent.Orchard.ContentEditors/Readme-CN.md) |
| 4 | DataTables | [Readme.md](Smartent.Orchard.DataTables/Readme.md) | [Readme-CN.md](Smartent.Orchard.DataTables/Readme-CN.md) |
| 5 | EmailClient | [Readme.md](Smartent.Orchard.EmailClient/Readme.md) | [Readme-CN.md](Smartent.Orchard.EmailClient/Readme-CN.md) |
| 6 | Extensions.Cms | [Readme.md](Smartent.Orchard.Extensions.Cms/Readme.md) | [Readme-CN.md](Smartent.Orchard.Extensions.Cms/Readme-CN.md) |
| 7 | Hosting.ApplicationInsights | [Readme.md](Smartent.Orchard.Hosting.ApplicationInsights/Readme.md) | [Readme-CN.md](Smartent.Orchard.Hosting.ApplicationInsights/Readme-CN.md) |
| 8 | Hosting.BuildVersion | [Readme.md](Smartent.Orchard.Hosting.BuildVersion/Readme.md) | [Readme-CN.md](Smartent.Orchard.Hosting.BuildVersion/Readme-CN.md) |
| 9 | Hosting.Tenants | [Readme.md](Smartent.Orchard.Hosting.Tenants/Readme.md) | [Readme-CN.md](Smartent.Orchard.Hosting.Tenants/Readme-CN.md) |
| 10 | JsonEditor | [Readme.md](Smartent.Orchard.JsonEditor/Readme.md) | [Readme-CN.md](Smartent.Orchard.JsonEditor/Readme-CN.md) |
| 11 | LoginAsAnybody | [Readme.md](Smartent.Orchard.LoginAsAnybody/Readme.md) | [Readme-CN.md](Smartent.Orchard.LoginAsAnybody/Readme-CN.md) |
| 12 | Marketing | [Readme.md](Smartent.Orchard.Marketing/Readme.md) | [Readme-CN.md](Smartent.Orchard.Marketing/Readme-CN.md) |
| 13 | Privacy | [Readme.md](Smartent.Orchard.Privacy/Readme.md) | [Readme-CN.md](Smartent.Orchard.Privacy/Readme-CN.md) |
| 14 | TrainingDemo | [Readme.md](Smartent.Orchard.TrainingDemo/Readme.md) | [Readme-CN.md](Smartent.Orchard.TrainingDemo/Readme-CN.md) |
| 15 | UIKit | [Readme.md](Smartent.Orchard.UIKit/Readme.md) | [Readme-CN.md](Smartent.Orchard.UIKit/Readme-CN.md) |
| 16 | VueJs | [Readme.md](Smartent.Orchard.VueJs/Readme.md) | [Readme-CN.md](Smartent.Orchard.VueJs/Readme-CN.md) |
| 17 | Walkthroughs | [Readme.md](Smartent.Orchard.Walkthroughs/Readme.md) | [Readme-CN.md](Smartent.Orchard.Walkthroughs/Readme-CN.md) |

**说明**：`Hosting.Tenants` 下各子包目录另有独立中英文 Readme；DataTables、UIKit 等若英文主文档较长，保留原 `Readme.md` 正文，加厚内容以 `Readme-CN.md` 与子项目目录为准。