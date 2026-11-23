# 检查本地 feed 是否含 core pack 应有的 nupkg。
# Verifies artifacts/smartent-nuget-local after Pack-SmartentLocalFeed.ps1 (non-Full).
param(
    [string]$OutputPath = ''
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $OutputPath) {
    $OutputPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}

if (-not (Test-Path $OutputPath)) {
    throw "Feed path not found: $OutputPath — run Pack-SmartentLocalFeed.ps1 first."
}

$requiredPackageIds = @(
    'Smartent.Orchard.Platform',
    'Lombiq.MSBuild.OrchardCore.Module.Sdk',
    'Lombiq.MSBuild.OrchardCore.Theme.Sdk',
    'Lombiq.MSBuild.OrchardCore.Tests.Sdk',
    'Smartent.Build.Npm.Targets',
    'Smartent.Build.NodeJs',
    'Smartent.Orchard.TrainingDemo',
    'Smartent.Core.Primitives',
    'Smartent.Test.Unit',
    'Smartent.Orchard.EInvoice',
    'Smartent.Orchard.EInvoice.Sample'
)

$nupkgs = Get-ChildItem -Path $OutputPath -Filter '*.nupkg' -File | ForEach-Object { $_.Name }
$manifestPath = Join-Path $OutputPath 'feed-manifest.txt'
$nupkgs | Sort-Object | Set-Content -Path $manifestPath -Encoding utf8
Write-Output "Wrote $manifestPath ($($nupkgs.Count) packages)"

$missing = @()
foreach ($id in $requiredPackageIds) {
    $found = $nupkgs | Where-Object { $_ -like "$id.*.nupkg" }
    if (-not $found) { $missing += $id }
}

if ($missing.Count -gt 0) {
    Write-Error ("Missing packages in feed: " + ($missing -join ', '))
    exit 1
}

Write-Output "Core feed verified ($($requiredPackageIds.Count) required ids present)."