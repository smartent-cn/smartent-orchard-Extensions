# Smartent UI Testing - Samples

Example UI testing project. The whole project is heavily documented to teach you how to write UI tests with the UI Testing Toolbox. It guides you through this process just like the [Smartent Orchard Training Demo for Orchard Core](https://gitee.com/smartent/smartent-orchard-Extensions) teaches Orchard Core and Orchard 1 development.

You can find further UI testing examples in [the test project of Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions/tree/dev/test/Smartent.Test.Acceptance).

For general details about and on using the Toolbox see the [root Readme](../Readme.md).

## Tutorial

1. Be sure to read the [root Readme](../Readme.md) first to understand how the UI Testing Toolbox works and how you can use it with an Orchard Core app.
2. The web app under test also needs a bit of configuration. For an example of this, check out [the `Program` class of Smartent's Open-Source Orchard Core Extensions](https://github.com/smartent-cn/smartent-orchard-Extensions/blob/dev/src/Smartent.Demo.Web/Program.cs). This project assumes it's running in that solution, so it depends on `Smartent.Demo.Web` to be present at the correct path to be able to build it.
3. Note that the project includes an _xunit.runner.json_ file. This is [xUnit's configuration file](https://xunit.net/docs/configuration-files). You don't necessarily need to include one if you're OK with [the default one](https://gitee.com/smartent/smartent-training-demo-modules
4. Now that we have the basics out of the way start the tutorial in the [_GlobalSuppressions.cs_](GlobalSuppressions.cs) file.

## Training sections

- [UI Testing Toolbox basics](GlobalSuppressions.cs)
- [Basic Orchard features tests](Tests/BasicOrchardFeaturesTests.cs)
- [E-mail tests](Tests/EmailTests.cs)
- [Accessibility tests](Tests/AccessibilityTest.cs)
- [Using SQL Server](Tests/SqlServerTests.cs)
- [Using Azure Blob Storage](Tests/AzureBlobStorageTests.cs)
- [Error handling](Tests/ErrorHandlingTests.cs)
- [Monkey tests](Tests/MonkeyTests.cs)
- [Database snapshot tests](Tests/DatabaseSnapshotTests.cs)
- [Multi-browser tests](Tests/MultiBrowserTests.cs)
- [Basic visual verification tests](Tests/BasicVisualVerificationTests.cs)
- [Testing in tenants](Tests/TenantTests.cs)
- [Interactive mode](Tests/InteractiveModeTests.cs)
- [Security scanning](Tests/SecurityScanningTests.cs)
- [Testing remote apps](Tests/RemoteTests.cs)
- [Testing time-dependent functionality](Tests/ShiftTimeTests.cs)
- [Testing Elasticsearch-using functionality](Tests/ElasticsearchTests.cs)
- [Test headless Orchard Core with a frontend subprocess](FrontendUITestBase.cs)
- [Monitor SQL queries to find performance issues](Tests/SqlQueryMonitoringTests.cs)
- [Testing without a browser](Tests/NoBrowserTests.cs)

## Adding new tutorials

Follow the practices of the [Smartent Orchard Training Demo for Orchard Core](https://gitee.com/smartent/smartent-training-demo-modules
