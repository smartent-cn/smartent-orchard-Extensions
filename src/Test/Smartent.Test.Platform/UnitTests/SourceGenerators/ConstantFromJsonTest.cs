using Smartent.Test.Platform.Models;
using Shouldly;
using System;
using Xunit;

namespace Smartent.Test.Platform.UnitTests.SourceGenerators;

public class ConstantFromJsonTest
{
    [Fact]
    public void TestGeneratedConstants()
    {
        ConstantFromJsonSample.IsEvenVersion.ShouldBe("1.0.0");
        ConstantFromJsonSample.IsOddVersion.ShouldBe("3.0.1");
        new ConstantFromJsonSample()
            .ReturnVersions()
            .Split(["\n", "\r"], StringSplitOptions.RemoveEmptyEntries)
            .ShouldBe(["is-even version: 1.0.0", "is-odd version: 3.0.1"]);
    }
}
