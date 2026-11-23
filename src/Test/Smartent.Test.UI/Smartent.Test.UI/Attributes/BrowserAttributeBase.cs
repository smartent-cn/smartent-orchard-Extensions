using Smartent.Test.UI.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Xunit.v3;

namespace Smartent.Test.UI.Attributes;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public abstract class BrowserAttributeBase : DataAttribute
{
    protected abstract Browser Browser { get; }

    public override ValueTask<IReadOnlyCollection<ITheoryDataRow>> GetData(MethodInfo testMethod, DisposalTracker disposalTracker) =>
        new(new[] { new TheoryDataRow(Browser) }.AsReadOnly());

    public override bool SupportsDiscoveryEnumeration() => true;
}
