using Smartent.Test.UI.Services;
using System;
using System.Threading.Tasks;

namespace Smartent.Test.UI;

#pragma warning disable S103 // Lines should not be too long, but the cref can't be broken up into multiple lines.
/// <summary>
/// Delegate with the signature of <see
/// cref="OrchardCoreUITestBase{TEntryPoint}.ExecuteTestAfterSetupAsync(System.Func{Smartent.Test.UI.Services.UITestContext,System.Threading.Tasks.Task}, Browser, Func{OrchardCoreUITestExecutorConfiguration, Task})"/>
/// so test case classes like <c>CustomAdminPrefixTestCase</c> in
/// <c>Smartent.Test.UI.Tests.UI</c> can easily depend on the method without having to define custom delegate
/// parameters.
/// </summary>
// If you change this, then also change the corresponding method below.
[Obsolete($"Pass {nameof(UITestBase)} instead.")]
public delegate Task ExecuteTestAfterSetupAsync(
    Func<UITestContext, Task> testAsync,
    Browser browser,
    Func<OrchardCoreUITestExecutorConfiguration, Task> changeConfigurationAsync);

/// <summary>
/// Delegate with the signature of <see
/// cref="OrchardCoreUITestBase{TEntryPoint}.ExecuteTestAfterSetupWithoutBrowserAsync(Func{UITestContext, Task}, Func{OrchardCoreUITestExecutorConfiguration, Task})"/>
/// so test case classes like <c>TimeoutTests</c> in
/// <c>Smartent.Test.UI.Tests.UI</c> can easily depend on the method without having to define custom delegate parameters.
/// </summary>
// If you change this, then also change the corresponding method below.
[Obsolete($"Pass {nameof(UITestBase)} instead.")]
public delegate Task ExecuteTestAfterSetupWithoutBrowserAsync(
    Func<UITestContext, Task> testAsync,
    Func<OrchardCoreUITestExecutorConfiguration, Task> changeConfigurationAsync);
#pragma warning restore S103 // Lines should not be too long
