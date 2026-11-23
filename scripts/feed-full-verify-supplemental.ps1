# NuGetVerify Web / Tests.UI 需要但不在 Smartent.Orchard.sln 图内的可发布工程（-Full 后增量 pack）。
function Get-SmartentFullVerifySupplementalPackProjects {
    @(
        @{ Rel = 'src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.csproj' },
        @{ Rel = 'src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.Pirsch/Smartent.Orchard.Marketing.Pirsch.csproj' },
        @{ Rel = 'src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.UrlShortener/Smartent.Orchard.Marketing.UrlShortener.csproj' },
        @{ Rel = 'src/Modules/Smartent.Orchard.Marketing/Smartent.Orchard.Marketing.Tests.UI/Smartent.Orchard.Marketing.Tests.UI.csproj' },
        @{ Rel = 'src/Modules/Smartent.Orchard.VueJs/Smartent.Orchard.VueJs.Resources/Smartent.Orchard.VueJs.Resources.csproj' },
        @{ Rel = 'src/Test/Smartent.Test.UI/Smartent.Test.UI.AdminTheme/Smartent.Test.UI.AdminTheme.csproj' },
        @{ Rel = 'src/Build/Smartent.Build.OrchardCore.Tests.UI.Sdk/Smartent.Build.OrchardCore.Tests.UI.Sdk.csproj'; Version = '2.1.1' },
        @{ Rel = 'src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.HealthChecks/Smartent.Orchard.Hosting.Tenants.HealthChecks.csproj' },
        @{ Rel = 'src/Modules/Smartent.Orchard.Hosting.Tenants/Smartent.Orchard.Hosting.Tenants.HealthChecks.Tests.UI/Smartent.Orchard.Hosting.Tenants.HealthChecks.Tests.UI.csproj' },
        @{ Rel = 'src/Libraries/Smartent.Orchard.ApiClient/Smartent.Orchard.ApiClient.Tests.UI/Smartent.Orchard.ApiClient.Tests.UI.csproj' }
    )
}