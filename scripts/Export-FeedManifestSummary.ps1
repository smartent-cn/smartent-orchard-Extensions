# Summarize artifacts/smartent-nuget-local/feed-manifest.txt by package id prefix.
param(
    [string]$OutputPath = ''
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $OutputPath) {
    $OutputPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}
$manifest = Join-Path $OutputPath 'feed-manifest.txt'
if (-not (Test-Path $manifest)) {
    throw "Missing $manifest — run Pack-SmartentLocalFeed.ps1 first."
}

$lines = Get-Content $manifest
$smartent = ($lines | Where-Object { $_ -like 'Smartent.*' }).Count
$lombiq = ($lines | Where-Object { $_ -like 'Lombiq.*' }).Count
$other = $lines.Count - $smartent - $lombiq

Write-Output "Feed: $OutputPath"
Write-Output "Total: $($lines.Count)  Smartent.*: $smartent  Lombiq.*: $lombiq  Other: $other"
Write-Output ''
$lines | ForEach-Object { Write-Output $_ }