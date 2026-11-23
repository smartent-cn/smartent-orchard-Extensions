# 根据本地 feed manifest 生成 NuGetVerify/Directory.Packages.local.props（不改动已提交的中央版本）。
param(
    [string]$FeedPath = '',
    [string]$LocalPropsPath = ''
)

$ErrorActionPreference = 'Stop'

function Test-NewerPackageVersion {
    param([string]$Candidate, [string]$Current)
    if ([string]::IsNullOrWhiteSpace($Current)) { return $true }
    try {
        $cBase = ($Candidate -split '-', 2)[0]
        $curBase = ($Current -split '-', 2)[0]
        $cV = [version]$cBase
        $curV = [version]$curBase
        if ($cV -gt $curV) { return $true }
        if ($cV -lt $curV) { return $false }
        return $Candidate.Length -gt $Current.Length
    }
    catch {
        return $Candidate -gt $Current
    }
}

$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $FeedPath) {
    $FeedPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}
if (-not $LocalPropsPath) {
    $LocalPropsPath = Join-Path $repoRoot 'NuGetVerify/Directory.Packages.local.props'
}
$manifest = Join-Path $FeedPath 'feed-manifest.txt'
if (-not (Test-Path $manifest)) {
    & (Join-Path $PSScriptRoot 'Export-FeedManifestSummary.ps1') -OutputPath $FeedPath | Out-Null
    if (-not (Test-Path $manifest)) { throw "Missing feed-manifest at $FeedPath" }
}

function Get-NupkgIdVersion {
    param([string]$FileName)
    if ($FileName -notmatch '\.nupkg$') { return $null }
    $base = $FileName -replace '\.nupkg$',''
    if ($base -notmatch '^(.+)\.(\d+\.\d+\.\d+(?:[-+][\w\.\-\+]*)?)$') { return $null }
  return @{ Id = $Matches[1]; Version = $Matches[2] }
}

$feedVersions = @{}
foreach ($line in Get-Content $manifest) {
    $parsed = Get-NupkgIdVersion $line
    if (-not $parsed) { continue }
    $id = $parsed.Id
    $ver = $parsed.Version
    if (-not $feedVersions.ContainsKey($id)) {
        $feedVersions[$id] = $ver
        continue
    }
    if (Test-NewerPackageVersion -Candidate $ver -Current $feedVersions[$id]) {
        $feedVersions[$id] = $ver
    }
}

$lines = @(
    '<Project>',
    '  <!-- 由 Align-NuGetVerifyVersionsToLocalFeed.ps1 生成；仅供本地 -Full feed 还原 Smartent.NuGet.sln。 -->',
    '  <ItemGroup>'
)
foreach ($id in ($feedVersions.Keys | Sort-Object)) {
    if ($id -notlike 'Smartent.*') { continue }
    $ver = $feedVersions[$id]
    $lines += "    <PackageVersion Update=`"$id`" Version=`"$ver`" />"
}
$lines += @(
    '  </ItemGroup>',
    '</Project>'
)

Set-Content -Path $LocalPropsPath -Value ($lines -join "`n") -Encoding utf8
Write-Output "Wrote $($feedVersions.Count) PackageVersion updates -> $LocalPropsPath"