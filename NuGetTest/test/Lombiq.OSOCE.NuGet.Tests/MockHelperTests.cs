using Smartent.Test.Unit.Helpers;
using Shouldly;
using Xunit;

namespace Lombiq.OSOCE.NuGet.Tests;

public class MockHelperTests
{
    [Fact]
    public void AutoMockerShouldBeInstantiated() => MockHelper.CreateAutoMockerInstance<MockedClass>().ShouldNotBeNull();
}
