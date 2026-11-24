# Quick start

> Parent: [docs/README.md](README.md)

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.VueJs`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.VueJs.Samples/Recipes/Smartent.Orchard.VueJs.Samples.Content.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.
