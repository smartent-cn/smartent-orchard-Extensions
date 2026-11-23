using System.Collections.Generic;
using static Smartent.Core.AspNet.Security.ContentSecurityPolicyDirectives;
using static Smartent.Core.AspNet.Security.ContentSecurityPolicyDirectives.CommonValues;
using static Smartent.Orchard.Platform.ResourceManagement.ResourceTypes;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Enable the <see cref="UnsafeEval"/> value for the <see cref="ScriptSrc"/> directive. This is necessary to evaluate
/// dynamic (not precompiled) templates. These are extensively used in stock Orchard Core. Also in many third party
/// modules where the DOM HTML template may contain Razor generated content.
/// </summary>
public class VueContentSecurityPolicyProvider : ResourceManagerContentSecurityPolicyProvider
{
    protected override IList<(string Type, string Name)> Resources { get; init; } =
    [
        (Script, "vuejs"),
        (ScriptModule, "vue"),
    ];

    protected override IReadOnlyCollection<string> DirectiveNameChain { get; } = [ScriptSrc];
    protected override string DirectiveValue => UnsafeEval;
}
