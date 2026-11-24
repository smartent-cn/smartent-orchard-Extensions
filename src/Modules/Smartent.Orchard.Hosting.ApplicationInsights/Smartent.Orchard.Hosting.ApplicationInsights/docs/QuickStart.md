# Quick start

> Parent: [docs/README.md](README.md)

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights/Smartent.Orchard.Hosting.ApplicationInsights.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.Hosting.ApplicationInsights`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.
