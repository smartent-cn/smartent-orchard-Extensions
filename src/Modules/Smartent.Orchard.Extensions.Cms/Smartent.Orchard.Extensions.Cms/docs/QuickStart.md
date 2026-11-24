# Quick start

> Parent: [docs/README.md](README.md)

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms/Smartent.Orchard.Extensions.Cms.csproj`.
3. Run the site, open **Configuration → Features**, enable **`CodeGeneration`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.Extensions.Cms.Tests.UI/Recipes/Smartent.Orchard.Extensions.Cms.Tests.UI.Lucide.Tests.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.
