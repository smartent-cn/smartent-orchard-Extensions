# Smartent UI Testing for Orchard Core

[![Smartent.Test.UI NuGet](https://img.shields.io/nuget/v/Smartent.Test.UI?label=Smartent.Test.UI)](https://www.nuget.org/packages/Smartent.Test.UI/) [![Smartent.Test.UI.AppExtensions NuGet](https://img.shields.io/nuget/v/Smartent.Test.UI.AppExtensions?label=Smartent.Test.UI.AppExtensions)](https://www.nuget.org/packages/Smartent.Test.UI.AppExtensions/) [![Smartent.Test.UI.Shortcuts NuGet](https://img.shields.io/nuget/v/Smartent.Test.UI.Shortcuts?label=Smartent.Test.UI.Shortcuts)](https://www.nuget.org/packages/Smartent.Test.UI.Shortcuts/) [![Latest version of 'Smartent.Test.UI' @ Cloudsmith](https://api-prd.cloudsmith.io/v1/badges/version/lombiq/open-source-orchard-core-extensions/nuget/Smartent.Test.UI/latest/xsp=True/?render=true&show_latest=true)](https://cloudsmith.io/~lombiq/repos/open-source-orchard-core-extensions/packages/detail/nuget/Smartent.Test.UI/latest/xsp=True/)

## About

Web UI testing toolbox mostly for Orchard Core applications. Everything you need to do UI testing with Selenium for an Orchard app is here.

Highlights:

- Builds on proven libraries like Selenium, Atata, and xUnit. See all the tools we use [here](Smartent.Test.UI/Docs/Tools.md).
- Execute fully self-contained, repeatable, parallelizable automated UI tests on Orchard Core apps, running locally or remotely.
- Do cross-browser testing with all current browsers (Chrome, Edge, and Firefox), both in normal and headless modes. The browsers are automatically installed to specific pinned versions. No unexpected browser update can break your tests!
- Check the HTML structure and behavior of the app, check for errors in the Orchard logs and browser logs. Start troubleshooting from the detailed full application dumps and test logs if a test fails.
- Start tests with a setup using recipes, start with an existing Orchard Core app or take snapshots in between tests and resume from there. Use SQLite or SQL Server database snapshots (but you can also use PostgreSQL or MySQL too without snapshots, see [this proof of concept](https://github.com/OrchardCMS/OrchardCore/pull/11194/files)).
- Use local file storage or Azure Blob Storage for Media.
- Test e-mail sending with a local SMTP server too. Everything just works.
- Built-in tests to check that basic Orchard Core features work, like login, registration, and content management. Demo video [here](https://www.youtube.com/watch?v=jmhq63sRZrI). And a [demo video](https://www.youtube.com/watch?v=BwHoLmgrV9g) about a proof of concept to add UI testing to Orchard.
- Built-in monkey testing functionality to try to break your app with random user interactions. Demo video [here](https://www.youtube.com/watch?v=pZbEsEz3tuE).
- Check for web content accessibility so people with disabilities can use your app properly too. You can also create accessibility reports for all pages.
- Check for the validity of the HTML markup either explicitly or automatically on all page changes.
- Detect duplicate SQL queries and oversized result sets to catch SELECT N+1 issues and missing filters, [see more here](Smartent.Test.UI/Docs/SqlQueryMonitoring.md), and a [demo video here](https://www.youtube.com/watch?v=YBdzXsREkxI).
- Reliability is built in, so you won't get false negatives.
- Use shortcuts for common Orchard Core operations like logging in or enabling features instead of going through the UI so you only test what you want, and it's also faster.
- Ready to use GitHub Actions workflows for CI builds and support for test grouping and error annotations in [Smartent GitHub Actions](https://github.com/features/actions). This feature is automatically enabled if a GitHub environment is detected.
- Support for [TeamCity test metadata reporting](https://www.jetbrains.com/help/teamcity/reporting-test-metadata.html) so you can see the important details and metrics of a test at a glance in a TeamCity CI/CD server.
- Visual verification testing: You can make the test fail if the look of the app changes. Demo video [here](https://www.youtube.com/watch?v=a-1zKjxTKkk).
- If your app uses a camera, a fake video capture source in Chrome is supported. [Here's a demo video of the feature](https://www.youtube.com/watch?v=sGcD0eJ2ytc), and check out the docs [here](Smartent.Test.UI/Docs/FakeVideoCaptureSource.md).
- Interactive mode for debugging the app while the test is paused. [Here's a demo of the feature](Smartent.Test.UI.Samples/Tests/InteractiveModeTests.cs), and a [demo video here](https://www.youtube.com/watch?v=ItNltaruWTY).
- Security scanning with [Zed Attack Proxy (ZAP)](https://www.zaproxy.org/), the world's most widely used web app security scanner, right from UI tests. See a demo video [here](https://www.youtube.com/watch?v=iUYivLkFbY4).
- Test time-dependent functionalities with a time shifting clock. See a demo video [here](https://www.youtube.com/watch?v=eK2C9BW98sM).
- Use Elasticsearch and test your app's search and indexing in a reliable manner.
- Test a headless app with a separate frontend. See a demo video [here](https://youtu.be/eK2C9BW98sM?si=Ehd_bbieXKOwm7vc&t=225).
- Write Selenium tests not just in .NET but also in JavaScript. See a demo video [here](https://youtu.be/eK2C9BW98sM?si=m0TXkBVRsFGD8lfr&t=415).

See a demo video of the project [here](https://www.youtube.com/watch?v=mEUg6-pad-E), and the Orchard Harvest 2023 conference talk about automated QA in Orchard Core [here](https://youtu.be/CHdhwD2NHBU). We also had an Orchard Harvest 2024 talk about security scanning [here](https://www.youtube.com/watch?v=FsOpo8EA4wE). Also, see our [Testing Toolbox](https://gitee.com/smartent/smartent-orchard-Extensions) for similar features for lower-level tests.

Looking not just for dynamic testing but also static code analysis? Check out our [.NET Analyzers project](https://gitee.com/smartent/smartent-orchard-Extensions)
We at [Smartent](https://gitee.com/smartent/) also used this module for the following projects:

- The new [City of Santa Monica website](https://santamonica.gov/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/helping-the-city-of-santa-monica-with-orchard-core-consulting)).
- The new [Smithsonian Folkways Recordings website](https://folkways.si.edu/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/smithsonian-folkways-recordings-now-upgraded-to-orchard-core)).
- The new [Smartent website](https://gitee.com/smartent/) when migrating it from Orchard 1 to Orchard Core ([see case study](https://gitee.com/smartent/blog/how-we-renewed-and-migrated-lombiq-com-from-orchard-1-to-orchard-core)).
- The new client portal for [WTW](https://www.wtwco.com/) ([see case study](https://gitee.com/smartent/blog/lombiq-s-journey-with-wtw-s-client-portal)).
- It also makes [DotNest, the Orchard Core SaaS](https://dotnest.com/) better.

Do you want to quickly try out this project and see it in action? Check it out in our [Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions) full Orchard Core solution and also see our other useful Orchard Core-related open-source projects!

## Documentation

- [Tutorial and samples](Smartent.Test.UI.Samples/Readme.md)
- [Projects in the UI Testing Toolbox](Smartent.Test.UI/Docs/Projects.md)
- [Making an Orchard Core app testable](Smartent.Test.UI/Docs/TestableOrchardCoreApps.md)
- [Creating tests](Smartent.Test.UI/Docs/CreatingTests.md)
- [Configuration](Smartent.Test.UI/Docs/Configuration.md)
- [Executing tests](Smartent.Test.UI/Docs/ExecutingTests.md)
- [SQL query monitoring](Smartent.Test.UI/Docs/SqlQueryMonitoring.md)
- [Fake video capture source](Smartent.Test.UI/Docs/FakeVideoCaptureSource.md)
- [Security scanning](Smartent.Test.UI/Docs/SecurityScanning.md)
- [Troubleshooting](Smartent.Test.UI/Docs/Troubleshooting.md)
- [Limits](Smartent.Test.UI/Docs/Limits.md)
- [Tools we use](Smartent.Test.UI/Docs/Tools.md)
- [Linux-specific considerations](Smartent.Test.UI/Docs/Linux.md)
- [Version migration guide](Smartent.Test.UI/Docs/Migration.md)

## Contributing and support

Bug reports, feature requests, comments, questions, code contributions and love letters are warmly welcome. You can send them to us via GitHub issues and pull requests. Please adhere to our [open-source guidelines](https://gitee.com/smartent/open-source-guidelines) while doing so.

This project is developed by [Smartent](https://gitee.com/smartent/). Commercial-grade support is available through Smartent.
