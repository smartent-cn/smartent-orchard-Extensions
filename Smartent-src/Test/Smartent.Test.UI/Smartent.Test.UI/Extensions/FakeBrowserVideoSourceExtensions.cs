using Smartent.Test.UI.Models;
using Smartent.Test.UI.Services;
using System;
using System.IO;

namespace Smartent.Test.UI.Extensions;

public static class FakeBrowserVideoSourceExtensions
{
    public static string SaveVideoToTempFolder(this FakeBrowserVideoSource source, string tempDirectoryPath)
    {
        using var fakeCameraSource = source.StreamProvider();
        var fakeCameraSourcePath = Path.ChangeExtension(
            OrchardCoreUITestExecutorConfiguration.GetTempDirectoryPathWithFallback(tempDirectoryPath, Guid.NewGuid().ToString()),
            GetExtension(source.Format));
        using var fakeCameraSourceFile = new FileStream(fakeCameraSourcePath, FileMode.CreateNew, FileAccess.Write);

        fakeCameraSource.CopyTo(fakeCameraSourceFile);

        return fakeCameraSourcePath;
    }

    private static string GetExtension(FakeBrowserVideoSourceFileFormat format) =>
        format switch
        {
            FakeBrowserVideoSourceFileFormat.MJpeg => "mjpeg",
            FakeBrowserVideoSourceFileFormat.Y4m => "y4m",
            _ => throw new ArgumentOutOfRangeException(nameof(format)),
        };
}
