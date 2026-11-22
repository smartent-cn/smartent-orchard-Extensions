using Smartent.Test.Unit.Helpers;
using Shouldly;
using Xunit;

namespace Smartent.NuGet.Tests;

public class MockHelperTests
{
    [Fact]
    public void AutoMockerShouldBeInstantiated() => MockHelper.CreateAutoMockerInstance<MockedClass>().ShouldNotBeNull();
}
