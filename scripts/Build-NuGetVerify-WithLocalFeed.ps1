# Pack Smartent.* 到本地 feed 并构建 NuGetVerify 全 sln（仅 PackageReference）。
param(
    [switch]$SkipPack,
    [switch]$CorePack,
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$feedScript = Join-Path $PSScriptRoot 'Pack-SmartentLocalFeed.ps1'
$nugetVerify = Join-Path $repoRoot 'NuGetVerify'
$localConfig = Join-Path $nugetVerify 'NuGet.config.local'

if (-not $SkipPack) {
    if ($CorePack) {
        & $feedScript
    }
    else {
        & $feedScript -Full
    }
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

if (-not (Test-Path $localConfig)) {
    throw "Missing $localConfig — copy from NuGet.config.local.example and enable SmartentLocal."
}

$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
Push-Location $nugetVerify
try {
    dotnet restore Smartent.NuGet.sln -c $Configuration --configfile $localConfig
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
    dotnet build Smartent.NuGet.sln -c $Configuration --no-restore --configfile $localConfig
    exit $LASTEXITCODE
}
finally {
    Pop-Location
}