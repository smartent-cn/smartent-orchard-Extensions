# M7#13：全量 pack + NuGetVerify Smartent.NuGet.sln 门禁。
param(
    [switch]$SkipPack
)

$ErrorActionPreference = 'Stop'
& (Join-Path $PSScriptRoot 'Invoke-M7CoreFeedGate.ps1') -SkipPack:$SkipPack
if (-not $?) { exit 1 }

& (Join-Path $PSScriptRoot 'Build-NuGetVerify-WithLocalFeed.ps1') -SkipPack:$SkipPack
exit $LASTEXITCODE