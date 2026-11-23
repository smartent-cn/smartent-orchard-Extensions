# 将 Smartent 可发布工程 pack 到本地 feed，供 NuGetVerify 仅 PackageReference 还原验证。
# Packs packable Smartent projects into a local feed for NuGetVerify PackageReference restores.
param(
    [switch]$Full,
    [switch]$SkipVerify,
    [switch]$WhatIf,
    [string]$OutputPath = ''
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
& (Join-Path $PSScriptRoot 'Assert-FeedCorePackVersions.ps1')
if (-not $?) { exit 1 }
if (-not $OutputPath) {
    $OutputPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}

New-Item -ItemType Directory -Force -Path $OutputPath | Out-Null
Write-Output "Output: $OutputPath"

if ($Full) {
    if ($WhatIf) {
        Write-Output 'WhatIf: dotnet pack Smartent.Orchard.sln -c Release'
        exit 0
    }
    Write-Output 'Packing Smartent.Orchard.sln (may take several minutes)...'
    dotnet pack (Join-Path $repoRoot 'Smartent.Orchard.sln') -c Release --output $OutputPath /p:ContinuousIntegrationBuild=true
    exit $LASTEXITCODE
}

. (Join-Path $PSScriptRoot 'feed-core-pack-versions.ps1')
$coreProjects = Get-SmartentFeedCorePackProjects

foreach ($entry in $coreProjects) {
    if ($WhatIf) {
        $verSuffix = if ($entry.Version) { " /p:Version=$($entry.Version)" } else { '' }
        Write-Output "WhatIf: pack $($entry.Rel)$verSuffix"
        continue
    }
    $rel = $entry.Rel
    $proj = Join-Path $repoRoot $rel
    if (-not (Test-Path $proj)) { throw "Missing project: $proj" }
    $packArgs = @('pack', $proj, '-c', 'Release', '--output', $OutputPath, '/p:ContinuousIntegrationBuild=true')
    if ($entry.Version) { $packArgs += "/p:Version=$($entry.Version)" }
    Write-Output "Packing $rel ..."
    & dotnet @packArgs
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

if ($WhatIf) { exit 0 }

Write-Output 'Core feed ready. Use -Full to pack the entire Smartent.Orchard.sln for NuGetVerify Web.'

if (-not $SkipVerify) {
    $verifyScript = Join-Path $PSScriptRoot 'Verify-SmartentLocalFeed.ps1'
    & $verifyScript -OutputPath $OutputPath
    exit $LASTEXITCODE
}