# Quick start

> Parent: [docs/README.md](README.md)

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient/Smartent.Orchard.EmailClient.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Default`** (and dependencies listed above).
4. Apply setup recipe if needed: `Smartent.Orchard.EmailClient.Samples/Recipes/Smartent.Orchard.EmailClient.Samples.recipe.json` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.
