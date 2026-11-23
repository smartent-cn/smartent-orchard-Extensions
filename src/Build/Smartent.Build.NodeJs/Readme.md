# Smartent Node.js Extensions

[![Smartent.NodeJs.Extensions NuGet](https://img.shields.io/nuget/v/Smartent.NodeJs.Extensions?label=Smartent.NodeJs.Extensions)](https://www.nuget.org/packages/Smartent.NodeJs.Extensions/)

## About

This project provides several MSBuild-integrated frontend asset pipelines - for building and linting SCSS, JS, Markdown and other arbitrary files. It uses static configuration from your _package.json_ with sensible defaults to free you from managing NPM packages and scripts yourself.

It makes use of our [NPM MSBuild Targets](https://gitee.com/smartent/smartent-training-demo-modules project, which can make NPM package management in your project a lot easier, too.

If you're interested in an overview of the rationale behind this project, and a glimpse at its inner workings, see [our blog post](https://orcharddojo.net/blog/delivering-a-node-js-asset-pipeline-as-a-nuget-package). Check out a demo video [here](https://www.youtube.com/watch?v=TINyWlItbpU), and the Orchard Harvest 2023 conference talk about automated QA in Orchard Core [here](https://youtu.be/CHdhwD2NHBU).

We at [Smartent](https://gitee.com/smartent/) also used this module for the following projects:

- The new [Smartent website](https://gitee.com/smartent/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/how-we-renewed-and-migrated-lombiq-com-from-orchard-1-to-orchard-core)).
- The new [Ik wil een taart website](https://ikwileentaart.nl/) ([see case study](https://dotnest.com/blog/revamping-ik-wil-een-taart-migrating-an-old-version-of-orchard-core-website-with-custom-theme-and-commerce-logic-to-dotnest)).
- The new [Show Orchard website](https://showorchard.com/) when migrating it from Orchard 1 DotNest to DotNest Core ([see case study](https://dotnest.com/blog/show-orchard-case-study-migrating-an-orchard-1-dotnest-site-to-orchard-core)).
- The new [Git-hg Mirror website](https://githgmirror.com/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/git-hg-mirror-is-running-on-orchard-core)).
- The new [Hastlayer website](https://hastlayer.com/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/modernization-and-orchard-core-migration-of-hastlayer-com)).
- The new [Orchard Dojo website](https://orcharddojo.net/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://orcharddojo.net/blog/another-lombiq-site-was-improved-orchard-dojo)).
- It also makes [DotNest, the Orchard Core SaaS](https://dotnest.com/) better.

Do you want to quickly try out this project and see it in action? Check it out, together with its accompanying [samples](Smartent.NodeJs.Extensions.Samples/Readme.md) [projects](Smartent.NodeJs.Extensions.Samples.NuGet/Readme.md), in our [Open-Source Orchard Core Extensions](https://gitee.com/smartent/smartent-training-demo-modules full Orchard Core solution. You will find our other useful Orchard Core-related open-source projects there, too.

## Prerequisites

1. To use this project, you will most of all need [Node.js](https://nodejs.org/) 18 or newer. We suggest installing the current LTS version which is higher than this minimum.
2. Please follow our recommended setup guides for [Windows](Smartent.NodeJs.Extensions/Docs/SetupWindows.md) or [Linux](Smartent.NodeJs.Extensions/Docs/SetupLinux.md), as applicable.

[PNPM](https://pnpm.io) 8 (for package management and script execution) is automatically enabled via `corepack` in the `EnablePnpm` MSBuild target, so you don't have to install it separately. Since PNPM 8 dropped support for Node.js 14 or older, those `node` versions won't work.

## Installation

This project can be consumed as a `git` submodule or as a `NuGet` package.

### As a Git submodule

In the case of using `Smartent.NodeJs.Extensions` as a git submodule, it is recommended to put it into a folder named _Lombiq.NodeJs.Extensions_ under the _src/Utilities_ folder, but you are free to use a different location (in that case you'll need to adjust the paths in the linter configuration files, see the docs on [ESLint](Smartent.NodeJs.Extensions/Docs/JavaScript.md#eslint-rules) and [Stylelint](Smartent.NodeJs.Extensions/Docs/Styles.md#stylelint-rules) configuration). You need to add [`Smartent.Npm.Targets`](https://gitee.com/smartent/smartent-training-demo-modules to the same folder, though.

Then, add a project reference to _Lombiq.NodeJs.Extensions/Smartent.NodeJs.Extensions.csproj_ and the following `Import` statements to your project file:

```xml
<!-- At the top: -->
<Import Project="..\..\Utilities\Smartent.NodeJs.Extensions\Smartent.NodeJs.Extensions\Smartent.NodeJs.Extensions.props" />

<!-- At the bottom: -->
<Import Project="..\..\Utilities\Smartent.NodeJs.Extensions\Smartent.NodeJs.Extensions\Smartent.NodeJs.Extensions.targets" />
```

> ℹ In case you've placed the submodule in a different location or your consuming project is nested deeper, adjust the paths as necessary.

Finally, ignore the files that `Smartent.NodeJs.Extensions` will create in the project root in the repository's _.gitignore_ file:

```gitignore
# Node.js Extensions automatically created files
/pnpm-lock.yaml
/package.json
```

### As a NuGet package

When adding `Smartent.NodeJs.Extensions` as a NuGet package, no further steps are necessary.

> ℹ Mind the following restrictions before choosing the NuGet package:

- No global [ESLint configuration](Smartent.NodeJs.Extensions/Docs/JavaScript.md#using-a-solution-wide-configuration)
- No global [Stylelint configuration](Smartent.NodeJs.Extensions/Docs/Styles.md#using-a-solution-wide-configuration)

## Usage

### Integration with MSBuild

The Smartent Node.js Extensions project tightly integrates with MSBuild and executes linting, compilation and minification tasks as part of the project's regular build process. All generated assets will be properly embedded in the project's assembly.

In case of warnings or errors during the execution of the different pipelines, respective MSBuild warnings and errors will be generated and surfaced. To increase the log verbosity, set `<NxVerbosity>` to a higher [importance](https://learn.microsoft.com/en-us/dotnet/api/microsoft.build.framework.messageimportance) value than the default `Low` in your project file.

### Configuration

This project contains some default configuration which can be customized to suit your needs. Your configuration needs to be placed in your project's _package.json_ file like so:

```json
"nodejsExtensions": {
  "assetsToCopy": [ { }, { } ],
  "scripts": { },
  "styles": { },
}
```

Refer to the respective [pipelines](#available-pipelines) for details.

### Available pipelines

Here's an overview of the asset pipelines this project makes available:

- [Asset Copying](Smartent.NodeJs.Extensions/Docs/AssetCopying.md)
- [JavaScript](Smartent.NodeJs.Extensions/Docs/JavaScript.md)
- [Markdown](Smartent.NodeJs.Extensions/Docs/Markdown.md)
- [Styles](Smartent.NodeJs.Extensions/Docs/Styles.md)

Please check out our dedicated [Samples](Smartent.NodeJs.Extensions.Samples/Readme.md) project to see the integration in action. The [NuGet Samples](Smartent.NodeJs.Extensions.Samples.NuGet/Readme.md) project shows how to use `Smartent.NodeJs.Extensions` as a NuGet package.

### How to trigger pipelines on demand

Many of the pipeline steps can be run from the _Visual Studio Task Runner Explorer_ to avoid building the whole project. Follow these steps to set this up:

1. Build your project once to bootstrap the integration of Smartent Node.js Extensions into your project.
2. Ensure any or all of the following `scripts` entries are part of your _package.json_:

    ```json
    "scripts": {
      "build":   "npm explore nodejs-extensions -- pnpm build",
      "compile": "npm explore nodejs-extensions -- pnpm compile",
      "lint":    "npm explore nodejs-extensions -- pnpm lint",
      "clean":   "npm explore nodejs-extensions -- pnpm clean",
      "watch":   "npm explore nodejs-extensions -- pnpm watch"
    }
    ```

3. Install the [NPM Task Runner](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.NpmTaskRunner64) extension.
4. Open the _Task Runner Explorer_ window and select your project. You should now see the above scripts under the `Custom` node.
5. Execute any of the available scripts by double-clicking.
6. You will now be able to inspect any errors and linter violations directly in the attached console.

### Scripts details

The `build` script is a wrapper for the `build:styles`, `build:scripts` and `build:assets` scripts, which each constitute their own pipeline, and which are executed in parallel. This is the script that's used during the regular project build.

The `compile` script is a wrapper for the `compile:styles`, `compile:scripts` and `compile:assets` scripts, which are also executed in parallel. This is the script that's used during NuGet packaging.

The `lint` script calls respective linting scripts for SCSS, JavaScript and Markdown files, which are part of their respective pipelines and are executed in parallel.

## Linting with GitHub Actions

If you only want linting and have no need for asset compilation, you can choose to utilize this project through a GitHub Action. It downloads Smartent.NodeJs.Extensions and executes the desired linting scripts on a local copy of your repository inside the workflow runner virtual machine. Check out a demo video [here](https://www.youtube.com/watch?v=0_AeAKuDdOM)!

### Full configuration

Create a new workflow or add the following step to an existing one that's triggered on pull requests:

```yml
  lint:
    name: Lint Scripts and Styles
    uses: Smartent/NodeJs-Extensions/.github/workflows/lint.yml@dev
    with:
      scripts: '
        {
          "src/Modules/OrchardCore.Commerce": { "scripts": { "source": "wwwroot/js" } },
          "src/Modules/OrchardCore.Commerce.ContentFields": { "scripts": { "source": "wwwroot/js" } },
          "src/Modules/OrchardCore.Commerce.Payment.Stripe": { "scripts": { "source": "wwwroot/js" } },
        }'
      styles-css: '
        {
          "src/Modules/OrchardCore.Commerce": { "styles": { "source": "wwwroot/css" } },
          "src/Modules/OrchardCore.Commerce.Payment": { "styles": { "source": "wwwroot/css" } },
        }'
```

You have to provide a JSON object for the `scripts` and `styles-css` inputs, where the property names are the relative paths of the projects you want to inspect, and the values become the`nodejsExtensions` properties in the temporarily generated _package.json_ files used for the linting operation. For more information, check out the workflow inputs [here](.github/workflows/lint.yml).

> [!TIP]
> Are all the script and stylesheets in the conventional directories used in the above example? Then you can use the simplified configuration, see the next section.

### Simplified configuration

If the CSS files to be linted are located in the _./wwwroot/css_ directory and the JS files are in the _./wwwroot/js_ (while the _./Assets/Scripts_ directory must not exist), then you can use the simplified comma-separated format:

```yml
  lint:
    name: Lint Scripts and Styles
    uses: Smartent/NodeJs-Extensions/.github/workflows/lint.yml@dev
    with:
      scripts: src/Modules/OrchardCore.Commerce, src/Modules/OrchardCore.Commerce.ContentFields, src/Modules/OrchardCore.Commerce.Payment.Stripe,
      styles-css: src/Modules/OrchardCore.Commerce, src/Modules/OrchardCore.Commerce.Payment,
```

### Markdown linting

By default, this action does Markdown linting on the whole repository as well. If you want to disable it, add `lint-markdown: 'false'` to the 'with:' section above.

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://gitee.com/smartent/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://gitee.com/smartent/). Commercial-grade support is available through Smartent.

### When a new Node.js LTS version is released

We always aim to support the latest LTS version of Node.js (what you can see [here](https://nodejs.org/en/about/previous-releases)). When a new LTS version is released, do the following:

- Update the PNPM version that `corepack` prepares to the one coming with the Node.js version in _NodeJsExtensionsNpmPackage.targets_ (look for `corepack prepare pnpm@`).
- If any of the installation instructions needs to change, update the [Linux setup guide](Smartent.NodeJs.Extensions/Docs/SetupLinux.md) as well as the [Windows setup guide](Smartent.NodeJs.Extensions/Docs/SetupWindows.md) (these already instruct to install the latest LTS version).
