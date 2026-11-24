# Quick start

> Parent: [docs/README.md](README.md)

1. Add `<ProjectReference Include="src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj" />` to your host (e.g. `Smartent.Demo.Web`).
2. Build: `dotnet build src/Modules/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion/Smartent.Orchard.Hosting.BuildVersion.csproj`.
3. Run the site, open **Configuration → Features**, enable **`Smartent.Orchard.Hosting.BuildVersion`** (and dependencies listed above).
4. Apply setup recipe if needed: `see Samples folder` from **Tools → Recipes**.
5. For demo host: `dotnet run --project src/Demo/Smartent.Demo.Web/Smartent.Demo.Web.csproj`.
