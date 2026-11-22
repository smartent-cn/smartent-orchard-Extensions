using Smartent.Orchard.Theme.Base.Native.Samples.Constants;
using Smartent.Orchard.Theme.Base.Native.Samples.Services;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Navigation;

namespace Smartent.Orchard.Theme.Base.Native.Samples;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // This shortcut is added by Smartent.Orchard.Platform.
        services.AddResourceManagementConfiguration<ResourceManagementOptionsConfiguration>();

        // This is a sample main menu item.
        services.AddNavigationProvider<AccountNavigationProvider>();

        // This creates an anonymous service that provides configuration to the ResourceFilterMiddleware (which is added
        // by Smartent.Orchard.Theme.Base.Core).
        services.AddResourceFilter(
            builder =>
            {
                builder.Always().RegisterStylesheet(ResourceNames.General);
                builder.Always().RegisterStylesheet(ResourceNames.Navigation);
                builder.WhenContentType("BlogPost").RegisterStylesheet(ResourceNames.BlogPost);
            },
            FeatureIds.NativeSamples);

        // Note that some related features, like frontend navigation providers and admin-side favicon configuration, are
        // not demonstrated here. Check out the non-Sass demos in Smartent.Orchard.Theme.Base.Samples project as well.
    }
}

// END OF TRAINING SECTION: Resource management
