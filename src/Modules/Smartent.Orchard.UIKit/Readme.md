# Smartent Orchard UI Kit for Orchard Core
> **中文说明**: [Readme-CN.md](Readme-CN.md)


[![Smartent.Orchard.UIKit NuGet](https://img.shields.io/nuget/v/Smartent.Orchard.UIKit?label=Smartent.Orchard.UIKit)](https://www.nuget.org/packages/Smartent.Orchard.UIKit/) [![Smartent.Orchard.UIKit.Tests.UI NuGet](https://img.shields.io/nuget/v/Smartent.Orchard.UIKit.Tests.UI?label=Smartent.Orchard.UIKit.Tests.UI)](https://www.nuget.org/packages/Smartent.Orchard.UIKit.Tests.UI/)

## About

This module contains reusable shapes like text editors, custom-style checkboxes, dropdown editors, and in the future potentially more complex editors. [Here](https://www.youtube.com/watch?v=PONfn2K8AHg) you can also see a demo of it.

This module is also available on all sites of [DotNest, the Orchard Core SaaS](https://dotnest.com/).

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

Add the module to your solution and enable the `Smartent Orchard UI Kit - Showcase page` feature if you want to check out the currently available shapes. Be sure that the dependencies can be found in the directory specified in the [Project file](Smartent.Orchard.UIKit/Smartent.Orchard.UIKit.csproj), or modify them where they are located in your solution. You can see them under `~/UIKitShowcase` after the feature is enabled. The example code for using these shapes can be seen in _[Views/Showcase/Showcase.cshtml](Smartent.Orchard.UIKit/Views/Showcase/Showcase.cshtml)_. This module contains only those stylings which are needed for these shapes to work.

To see documentation on the Bootstrap controls, see [Docs/BootstrapControls.md](Smartent.Orchard.UIKit/Docs/BootstrapControls.md).

### Custom class and id

For your own styling you can override the default class stylings, or you can create a new class and add it to the shape block via the `BlockClassName` parameter.

If it is needed to add an ID for the container block, then you can do that with the `BlockId` parameter.

### Content Parts

- HTML Title part: Similar to the stock Title part, but a HTML editor is used instead of a plain text editor. It updates the content item's display text with the provided HTML's inner text content as well.

## Smartent Orchard UI Kit - Widgets

[Smartent Orchard UI Kit - Widgets](Smartent.Orchard.UIKit.Widgets/) is a module that provides widgets based on the Smartent Orchard UI Kit reusable shapes.

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://gitee.com/smartent/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://gitee.com/smartent/). Commercial-grade support is available through Smartent.