# Platform / Orchard

迁入目标（M3 起）：原 `Smartent.HelpfulLibraries.OrchardCore`、`LinqToDb`、`Refit`、`OrchardCore.Testing` 等。

| 状态 | 项目 |
|------|------|
| **M3 已完成** | [Smartent.Orchard.Platform.Data.LinqToYesSql](Smartent.Orchard.Platform.Data.LinqToYesSql/Readme.md) ← ~~`Smartent.HelpfulLibraries.LinqToDb`~~ |
| **M3 已完成** | [Smartent.Orchard.Http.Refit](Smartent.Orchard.Http.Refit/Readme.md) ← ~~`Smartent.HelpfulLibraries.Refit`~~ |
| **M3 已完成** | [Smartent.Orchard.Platform](Smartent.Orchard.Platform/Readme.md) ← ~~`Smartent.HelpfulLibraries.OrchardCore`~~（单包，垂直拆包 TBD） |
| **M3 已完成** | [Smartent.Test.OrchardCore](../../../Test/Smartent.Test.OrchardCore/Readme.md) ← ~~`Smartent.HelpfulLibraries.OrchardCore.Testing`~~（位于 `src/Test/`） |

拆包细节见 [M3-Platform-HelpfulLibraries.md](../../../重构-重组-改名项目方案/projects/M3-Platform-HelpfulLibraries.md)。M2 `Smartent.Core.*` 见 `../Core/`。