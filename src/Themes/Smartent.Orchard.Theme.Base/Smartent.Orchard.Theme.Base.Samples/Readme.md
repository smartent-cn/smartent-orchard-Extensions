# Smartent Orchard Theme Base for Orchard Core - Samples

> [!WARNING]
> The current latest version of `Smartent.Orchard.Theme.Base.Samples` is deprecated. It will keep working for the foreseeable future, but won't receive any updates besides security fixes.

## About

Example Orchard Core theme that makes use of Smartent Orchard Theme Base for Orchard Core.

For general details about and usage instructions see the [root Readme](../Readme.md).

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://gitee.com/smartent/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Training sections

This module doesn't cover Orchard Core basics. Instead, sometimes we reference the [Smartent Orchard Training Demo for Orchard Core](https://gitee.com/smartent/smartent-orchard-Extensions) which does. The [Open-Source Orchard Core Extensions](https://gitee.com/smartent/smartent-orchard-Extensions) repository includes both the Training Demo and this project.

If you need help with setting up SCSS compilation, read the documentation of [Smartent Node.js Extensions](https://gitee.com/smartent/smartent-orchard-Extensions) first. Also check out the [package.json](package.json) file in this project.

You can start with any of the top-level sections, but the indented sections should be followed in sequence.

- Make a custom theme
  - [Configuration](Manifest.cs)
  - [Layout injection](Views/Widget-LayoutInjection.cshtml)
  - [Sass styling and structure](Assets/Styles/site.scss)
- [Front-end navigation via the `"main"` menu](Services/AccountNavigationProvider.cs)
- [Set up favicon using recipe migrations](Migrations/RecipeMigrations.cs)
