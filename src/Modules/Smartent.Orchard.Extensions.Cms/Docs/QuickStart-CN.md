# 快速开始

> 上级：[docs/Readme-CN.md](../docs/Readme-CN.md)

1. 在宿主（如 `Smartent.Demo.Web`）中添加：`<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />`。
2. 构建：`dotnet build src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj`。
3. 运行站点，在 **配置 → 功能** 中启用 **`CodeGeneration`** 及上表依赖。
4. 需要时从 **工具 → 配方** 执行：`Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.Lucide.Tests.recipe.json`。
5. Demo 宿主：`dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`。
