# Demo | 演示

> **English**: [README.md](README.md)

`src/Demo/` 存放平台与模块能力的演示宿主与样例（**非**生产独立产品）。

| 目录 | 说明 | 文档 |
|------|------|------|
| `Smartent.Demo.Web/` | 培训/demo 主 Web 宿主 | [Readme-CN.md](Smartent.Demo.Web/Readme-CN.md) |
| `Smartent.Demo.Samples/` | 聚合 OSOCE 样例模块 | [Readme-CN.md](Smartent.Demo.Samples/Readme-CN.md) |
| `Smartent.Demo.Platform.Samples/` | 平台库演示（原 HelpfulLibraries.Samples） | [Readme-CN.md](Smartent.Demo.Platform.Samples/Smartent.Demo.Platform.Samples/Readme-CN.md) |

## 本地运行

```powershell
dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj
```

启用功能：在后台「配置 → 功能」中勾选各 Demo / 模块 Feature；配置节使用 `Smartent_*`，不读取遗留 `Lombiq_*`。

## 测试

以 `Smartent.Orchard.sln` Release 构建为门禁；UI 测试见 `src/Test/Smartent.Test.UI/Readme-CN.md`。