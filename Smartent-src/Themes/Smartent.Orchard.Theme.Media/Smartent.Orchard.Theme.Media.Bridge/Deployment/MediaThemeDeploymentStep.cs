using OrchardCore.Deployment;

namespace Smartent.Orchard.Theme.Media.Bridge.Deployment;

public class MediaThemeDeploymentStep : DeploymentStep
{
    public MediaThemeDeploymentStep() => Name = "MediaTheme";

    public bool ClearMediaThemeFolder { get; set; }
}
