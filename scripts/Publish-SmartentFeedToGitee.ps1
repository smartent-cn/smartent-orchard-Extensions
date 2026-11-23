# 将 artifacts/smartent-nuget-local 中的 nupkg 推送到 Gitee Packages（或任意 v3 feed）。
param(
    [string]$FeedPath = '',
    [string]$SourceUrl = '',
    [string]$ApiKey = '',
    [switch]$WhatIf,
    [switch]$DryRun
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $FeedPath) {
    $FeedPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}
if (-not $SourceUrl) {
    $SourceUrl = $env:GITEE_NUGET_SOURCE_URL
}
if (-not $ApiKey) {
    $ApiKey = $env:GITEE_NUGET_API_KEY
}

if (-not (Test-Path $FeedPath)) {
    throw "Missing feed folder: $FeedPath — run Pack-SmartentLocalFeed.ps1 first."
}

$nupkgs = Get-ChildItem -Path $FeedPath -Filter '*.nupkg' -File
if ($nupkgs.Count -eq 0) { throw "No .nupkg under $FeedPath" }

if ($WhatIf -or $DryRun) {
    Write-Output "WhatIf: dotnet nuget push ($($nupkgs.Count) packages) -> $SourceUrl"
    $nupkgs | ForEach-Object { Write-Output "  $($_.Name)" }
    exit 0
}

if ([string]::IsNullOrWhiteSpace($SourceUrl)) {
    throw 'Set GITEE_NUGET_SOURCE_URL or pass -SourceUrl (see docs/releases/M7-FirstNuGet-Release-Draft.md).'
}
if ([string]::IsNullOrWhiteSpace($ApiKey)) {
    throw 'Set GITEE_NUGET_API_KEY or pass -ApiKey (do not commit tokens).'
}

foreach ($pkg in $nupkgs) {
    Write-Output "Pushing $($pkg.Name) ..."
    & dotnet nuget push $pkg.FullName --source $SourceUrl --api-key $ApiKey --skip-duplicate
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

Write-Output "Pushed $($nupkgs.Count) packages. Verify with: ./scripts/Build-NuGetVerify-WithLocalFeed.ps1 -SkipPack"
exit 0