# 将 Smartent 可发布工程 pack 到本地 feed，供 NuGetVerify 仅 PackageReference 还原验证。
# Packs packable Smartent projects into a local feed for NuGetVerify PackageReference restores.
param(
    [switch]$Full,
    [switch]$SkipVerify,
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

$coreProjects = . (Join-Path $PSScriptRoot 'feed-core-pack-versions.ps1')

foreach ($entry in $coreProjects) {
    $rel = $entry.Rel
    $proj = Join-Path $repoRoot $rel
    if (-not (Test-Path $proj)) { throw "Missing project: $proj" }
    $packArgs = @('pack', $proj, '-c', 'Release', '--output', $OutputPath, '/p:ContinuousIntegrationBuild=true')
    if ($entry.Version) { $packArgs += "/p:Version=$($entry.Version)" }
    Write-Output "Packing $rel ..."
    & dotnet @packArgs
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

Write-Output 'Core feed ready. Use -Full to pack the entire Smartent.Orchard.sln for NuGetVerify Web.'

if (-not $SkipVerify) {
    $verifyScript = Join-Path $PSScriptRoot 'Verify-SmartentLocalFeed.ps1'
    & $verifyScript -OutputPath $OutputPath
    exit $LASTEXITCODE
}