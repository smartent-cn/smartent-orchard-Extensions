# 按 NuGetVerify Web/Tests.UI 的 Smartent.* 引用与 feed-manifest 差集，增量 pack 不在 sln 内的工程。
param(
    [string]$FeedPath = '',
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $FeedPath) {
    $FeedPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}
. (Join-Path $PSScriptRoot 'feed-full-verify-supplemental.ps1')

function Get-NupkgIdFromFileName {
    param([string]$FileName)
    if ($FileName -notmatch '\.nupkg$') { return $null }
    $base = $FileName -replace '\.nupkg$',''
    if ($base -notmatch '^(.+)\.(\d+\.\d+\.\d+(?:[-+][\w\.\-\+]*)?)$') { return $null }
    return $Matches[1]
}

$manifest = Join-Path $FeedPath 'feed-manifest.txt'
$inFeed = @{}
if (Test-Path $manifest) {
    foreach ($line in Get-Content $manifest) {
        $id = Get-NupkgIdFromFileName $line
        if ($id) { $inFeed[$id] = $true }
    }
}

$refs = @()
$nugetVerify = Join-Path $repoRoot 'NuGetVerify'
foreach ($proj in @(
        'src/Smartent.NuGet.Web/Smartent.NuGet.Web.csproj',
        'test/Smartent.NuGet.Tests.UI/Smartent.NuGet.Tests.UI.csproj')) {
    $path = Join-Path $nugetVerify $proj
    $text = Get-Content -LiteralPath $path -Raw
    [regex]::Matches($text, 'PackageReference\s+Include="(Smartent\.[^"]+)"') | ForEach-Object {
        $refs += $_.Groups[1].Value
    }
}
$needed = $refs | Sort-Object -Unique | Where-Object { -not $inFeed.ContainsKey($_) }

$idToRel = @{}
Get-ChildItem -Path (Join-Path $repoRoot 'Smartent-src') -Recurse -Filter '*.csproj' -File -ErrorAction SilentlyContinue |
    Where-Object { $_.FullName -notmatch '[\\/]node_modules[\\/]' } | ForEach-Object {
    $t = Get-Content -LiteralPath $_.FullName -Raw
    if ($t -match '<IsPackable>\s*false\s*</IsPackable>') { return }
    if ($t -match '<PackageId>\s*([^<]+)\s*</PackageId>') {
        $rel = $_.FullName.Replace("$repoRoot\", '').Replace('\', '/')
        $idToRel[$Matches[1].Trim()] = $rel
    }
}
foreach ($entry in Get-SmartentFullVerifySupplementalPackProjects) {
    $proj = Join-Path $repoRoot $entry.Rel
    $t = Get-Content -LiteralPath $proj -Raw
    if ($t -match '<PackageId>\s*([^<]+)\s*</PackageId>') {
        $idToRel[$Matches[1].Trim()] = $entry.Rel
    }
}

$packed = 0
foreach ($id in $needed) {
    if (-not $idToRel.ContainsKey($id)) {
        Write-Warning "No packable project for required package $id"
        continue
    }
    $rel = $idToRel[$id]
    $proj = Join-Path $repoRoot ($rel -replace '/', '\')
    $entry = Get-SmartentFullVerifySupplementalPackProjects | Where-Object { $_.Rel -eq $rel } | Select-Object -First 1
    $packArgs = @('pack', $proj, '-c', $Configuration, '--output', $FeedPath, '/p:ContinuousIntegrationBuild=true')
    if ($entry -and $entry.Version) { $packArgs += "/p:Version=$($entry.Version)" }
    Write-Output "Gap pack $id -> $rel"
    & dotnet @packArgs
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
    $packed++
}

if ($packed -gt 0) {
    $nupkgs = Get-ChildItem -Path $FeedPath -Filter '*.nupkg' -File | ForEach-Object { $_.Name }
    $nupkgs | Sort-Object | Set-Content -Path $manifest -Encoding utf8
    Write-Output "Refreshed feed-manifest ($($nupkgs.Count) packages)."
}
elseif ($needed.Count -eq 0) {
    Write-Output 'No supplemental gaps.'
}
exit 0