# 将 Smartent 可发布工程 pack 到本地 feed，供 NuGetVerify 仅 PackageReference 还原验证。
# Packs packable Smartent projects into a local feed for NuGetVerify PackageReference restores.
param(
    [switch]$Full,
    [string]$OutputPath = ''
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $OutputPath) {
    $OutputPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}

New-Item -ItemType Directory -Force -Path $OutputPath | Out-Null
Write-Output "Output: $OutputPath"

if ($Full) {
    Write-Output 'Packing Smartent.Orchard.sln (may take several minutes)...'
    dotnet pack (Join-Path $repoRoot 'Smartent.Orchard.sln') -c Release --output $OutputPath /p:ContinuousIntegrationBuild=true
    exit $LASTEXITCODE
}

$coreProjects = @(
    'Smartent-src/Platform/Orchard/Smartent.Orchard.Platform/Smartent.Orchard.Platform.csproj',
    'Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Module.Sdk/Lombiq.MSBuild.OrchardCore.Module.Sdk.csproj',
    'Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Theme.Sdk/Lombiq.MSBuild.OrchardCore.Theme.Sdk.csproj',
    'Smartent-src/Build/Lombiq.MSBuild.OrchardCore.Tests.Sdk/Lombiq.MSBuild.OrchardCore.Tests.Sdk.csproj',
    'Smartent-src/Build/Smartent.Build.Npm.Targets/Smartent.Build.Npm.Targets.csproj',
    'Smartent-src/Build/Smartent.Build.NodeJs/Smartent.Build.NodeJs/Smartent.Build.NodeJs.csproj',
    'Smartent-src/Modules/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo/Smartent.Orchard.TrainingDemo.csproj'
)

foreach ($rel in $coreProjects) {
    $proj = Join-Path $repoRoot $rel
    if (-not (Test-Path $proj)) { throw "Missing project: $proj" }
    Write-Output "Packing $rel ..."
    dotnet pack $proj -c Release --output $OutputPath /p:ContinuousIntegrationBuild=true
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

Write-Output 'Core feed ready. Use -Full to pack the entire Smartent.Orchard.sln for NuGetVerify Web.'