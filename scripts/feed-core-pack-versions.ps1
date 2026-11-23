# 与 NuGetVerify/Directory.Packages.props 中央版本对齐，供本地 feed pack 使用。
# Align with NuGetVerify/Directory.Packages.props for restore smoke tests.
@(
    @{ Rel = 'Smartent-src/Platform/Core/Smartent.Core.Primitives/Smartent.Core.Primitives.csproj'; Version = '13.1.0' }
    @{ Rel = 'Smartent-src/Platform/Core/Smartent.Core.AspNet/Smartent.Core.AspNet.csproj'; Version = '13.1.0' }
    @{ Rel = 'Smartent-src/Test/Smartent.Test.Unit/Smartent.Test.Unit.csproj'; Version = '6.0.1' }
    @{ Rel = 'Smartent-src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.csproj'; Version = '2.0.1' }
    @{ Rel = 'Smartent-src/Libraries/Smartent.Orchard.EInvoice/Smartent.Orchard.EInvoice.Sample/Smartent.Orchard.EInvoice.Sample.csproj'; Version = '2.0.1' }
    @{ Rel = 'Smartent-src/Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj'; Version = '13.1.0' }
    @{ Rel = 'Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Module.Sdk/Lombiq.MSBuild.OrchardCore.Module.Sdk.csproj'; Version = '' }
    @{ Rel = 'Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Theme.Sdk/Lombiq.MSBuild.OrchardCore.Theme.Sdk.csproj'; Version = '' }
    @{ Rel = 'Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Tests.Sdk/Lombiq.MSBuild.OrchardCore.Tests.Sdk.csproj'; Version = '' }
    @{ Rel = 'Smartent-src/Build/Smartent.Build.Npm.Targets/Smartent.Build.Npm.Targets.csproj'; Version = '1.5.3' }
    @{ Rel = 'Smartent-src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj'; Version = '3.0.0' }
    @{ Rel = 'Smartent-src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj'; Version = '1.0.0' }
)