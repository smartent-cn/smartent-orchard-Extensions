# Align pack versions with NuGetVerify/Directory.Packages.props (see Assert-FeedCorePackVersions.ps1).
function Get-SmartentFeedCorePackProjects {
    return @(
        @{ Rel = 'src/Platform/Core/Smartent.Core.Primitives/Smartent.Core.Primitives.csproj'; Version = '13.1.0'; PackageId = 'Smartent.Core.Primitives' }
        @{ Rel = 'src/Platform/Core/Smartent.Core.AspNet/Smartent.Core.AspNet.csproj'; Version = '13.1.0'; PackageId = 'Smartent.Core.AspNet' }
        @{ Rel = 'src/Test/Smartent.Test.Unit/Smartent.Test.Unit.csproj'; Version = '6.0.1'; PackageId = 'Smartent.Test.Unit' }
        @{ Rel = 'src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.csproj'; Version = '2.0.1'; PackageId = 'Smartent.Orchard.EInvoice' }
        @{ Rel = 'src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.Sample/Smartent.Orchard.EInvoice.Sample.csproj'; Version = '2.0.1'; PackageId = 'Smartent.Orchard.EInvoice.Sample' }
        @{ Rel = 'src/Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj'; Version = '13.1.0'; PackageId = 'Smartent.Orchard.Platform' }
        @{ Rel = 'src/Build/Smartent.Build.LibMan.Targets/Smartent.Build.LibMan.Targets.csproj'; Version = '2.1.1'; PackageId = 'Smartent.Build.LibMan.Targets' }
        @{ Rel = 'src/Build/Smartent.Build.OrchardCore.Module.Sdk/Smartent.Build.OrchardCore.Module.Sdk.csproj'; Version = '2.1.1'; PackageId = 'Smartent.Build.OrchardCore.Module.Sdk' }
        @{ Rel = 'src/Build/Smartent.Build.OrchardCore.Theme.Sdk/Smartent.Build.OrchardCore.Theme.Sdk.csproj'; Version = '2.1.1'; PackageId = 'Smartent.Build.OrchardCore.Theme.Sdk' }
        @{ Rel = 'src/Build/Smartent.Build.OrchardCore.Tests.Sdk/Smartent.Build.OrchardCore.Tests.Sdk.csproj'; Version = '2.1.1'; PackageId = 'Smartent.Build.OrchardCore.Tests.Sdk' }
        @{ Rel = 'src/Build/Smartent.Build.Npm.Targets/Smartent.Build.Npm.Targets.csproj'; Version = '1.5.3'; PackageId = 'Smartent.Build.Npm.Targets' }
        @{ Rel = 'src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj'; Version = '3.0.0'; PackageId = 'Smartent.Build.NodeJs' }
        @{ Rel = 'src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj'; Version = '1.0.0'; PackageId = 'Smartent.Orchard.TrainingDemo' }
        @{ Rel = 'tools/Smartent.Build.Analyzers/Smartent.Build.Analyzers/Smartent.Build.Analyzers.csproj'; Version = '7.0.1-alpha.0.osoe-1333'; PackageId = 'Smartent.Build.Analyzers' }
        @{ Rel = 'tools/Smartent.Build.Analyzers/Smartent.Build.Analyzers.OrchardCore/Smartent.Build.Analyzers.OrchardCore.csproj'; Version = '7.0.1-alpha.0.osoe-1333'; PackageId = 'Smartent.Build.Analyzers.OrchardCore' }
    )
}