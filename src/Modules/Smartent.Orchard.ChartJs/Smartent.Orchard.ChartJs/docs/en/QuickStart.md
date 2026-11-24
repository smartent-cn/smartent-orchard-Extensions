# Quick start

> Index: [README.md](README.md) · Gateway: [../README.md](../README.md)

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs/Smartent.Orchard.ChartJs.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.ChartJs`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.ChartJs.Samples/Recipes/Smartent.Orchard.ChartJs.Samples.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.
