using Smartent.Test.UI.Models;
using Smartent.Test.UI.Services;
using Smartent.Orchard.VueJs.Tests.UI.Assets.Media;

namespace Smartent.Orchard.VueJs.Tests.UI.Extensions;

public static class BrowserConfigurationExtensions
{
    public static void ConfigureFakeVideoSourceForNegativeTest(this BrowserConfiguration browserConfiguration) =>
        browserConfiguration.ConfigureFakeVideoSource("richard.roe.mjpeg");

    public static void ConfigureFakeVideoSourceForPositiveTest(this BrowserConfiguration browserConfiguration) =>
        browserConfiguration.ConfigureFakeVideoSource("john.doe.mjpeg");

    private static void ConfigureFakeVideoSource(this BrowserConfiguration browserConfiguration, string resource) =>
        browserConfiguration.FakeVideoSource = new FakeBrowserVideoSource
        {
            StreamProvider = () => typeof(DirectoryPlaceholder)
                .Assembly
                .GetManifestResourceStream(typeof(DirectoryPlaceholder), resource),
            Format = FakeBrowserVideoSourceFileFormat.MJpeg,
        };
}
