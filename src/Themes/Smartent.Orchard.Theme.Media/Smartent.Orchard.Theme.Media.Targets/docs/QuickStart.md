# Quick start

> Parent: [docs/README.md](README.md)

Install the [NuGet package](https://www.nuget.org/packages/Smartent.Orchard.Theme.Media.Targets/) or if you use the project from a submodule, add the following lines to the csproj file. Make sure that the paths are pointing to the _Smartent.Orchard.Theme.Media.Targets.props_ and _Smartent.Orchard.Theme.Media.Targets.targets_ files of this project.

```xml
    <Import Project="path/to/Smartent.Orchard.Theme.Media.Targets/Smartent.Orchard.Theme.Media.Targets.props" />
    <Import Project="path/to/Smartent.Orchard.Theme.Media.Targets/Smartent.Orchard.Theme.Media.Targets.targets" />
```

If your project name ends with `.Theme`, the recipe will automatically use the same name but ending with `.Mediatheme` instead. If it has a different suffix, override the `MediaThemeRecipeFileName` property to modify the Recipe file name and the name property in the recipe. (It should always end with `.Mediatheme` for successful deployment.)

```xml
<PropertyGroup>
    <MediaThemeRecipeFileName>Sample.MediaTheme</MediaThemeRecipeFileName>
</PropertyGroup>
```

Add a dotnet-tools.json file into the .config folder in your module:

```json
{
  "version": 1,
  "isRoot": true,
  "tools": {
    "smartent.hosting.mediatheme.deployer": {
      "version": "3.0.1",
      "commands": [
        "media-theme-deploy"
      ]
    }
  }
}
```

To have a successful run you must follow the required shape templates name convention as it is also required for the [Media Theme Deployer](https://gitee.com/smartent/smartent-orchard-Extensions)
