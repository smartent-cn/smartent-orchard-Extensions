# Pack Smartent.* 到本地 feed 并构建 NuGetVerify 全 sln（仅 PackageReference）。
<#
.SYNOPSIS
  Full NuGetVerify sln with local or remote Smartent feed.

.PARAMETER SkipPack
  Skip pack; requires existing feed and NuGet.config.local.

.PARAMETER CorePack
  Use Pack-SmartentLocalFeed without -Full (insufficient for Web).

.EXAMPLE
  ./scripts/Build-NuGetVerify-WithLocalFeed.ps1

.EXAMPLE
  Copy-Item NuGetVerify/NuGet.config.local.example NuGetVerify/NuGet.config.local
  ./scripts/Build-NuGetVerify-WithLocalFeed.ps1 -SkipPack
#>
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
        Write-Output 'Step 1/3: Pack-SmartentLocalFeed (core)...'
        & $feedScript
    }
    else {
        Write-Output 'Step 1/3: Pack-SmartentLocalFeed -Full (long-running)...'
        & $feedScript -Full
    }
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}
else {
    Write-Output 'Step 1/3: Skip pack (existing feed).'
}

if (-not (Test-Path $localConfig)) {
    throw "Missing $localConfig — copy from NuGet.config.local.example and enable SmartentLocal."
}

$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
Push-Location $nugetVerify
try {
    Write-Output 'Step 2/3: dotnet restore Smartent.NuGet.sln ...'
    dotnet restore Smartent.NuGet.sln -c $Configuration --configfile $localConfig
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
    Write-Output 'Step 3/3: dotnet build Smartent.NuGet.sln ...'
    dotnet build Smartent.NuGet.sln -c $Configuration --no-restore --configfile $localConfig
    exit $LASTEXITCODE
}
finally {
    Pop-Location
}