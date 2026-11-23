# Standalone NuGetVerify PackageReference restore against core local feed.
param(
    [switch]$SkipPack,
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$nugetVerify = Join-Path $repoRoot 'NuGetVerify'
$restoreConfig = Join-Path $nugetVerify 'NuGet.config'
Write-Output "Using $restoreConfig (SmartentLocal + nuget.org)."

if (-not $SkipPack) {
    & (Join-Path $PSScriptRoot 'Pack-SmartentLocalFeed.ps1')
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

& (Join-Path $PSScriptRoot 'Seed-LocalFeedSdkToNuGetCache.ps1')
if (-not $?) { exit 1 }

$projects = @(
    'test/Smartent.NuGet.Tests/Smartent.NuGet.Tests.csproj'
    'src/Modules/Smartent.NuGet.TestModule/Smartent.NuGet.TestModule.csproj'
    'src/Themes/Smartent.NuGet.TestTheme/Smartent.NuGet.TestTheme.csproj'
)

$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
Push-Location $nugetVerify
try {
    foreach ($rel in $projects) {
        Write-Output "Restoring (standalone) $rel ..."
        & dotnet restore $rel `
            --configfile $restoreConfig `
            -p:Configuration=$Configuration `
            -p:ForceStandaloneNuGetVerify=true
        if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
    }
    Write-Output 'Core PackageReference restore succeeded.'
}
finally {
    Pop-Location
}