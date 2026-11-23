# 校验 feed-core-pack-versions.ps1 与 NuGetVerify/Directory.Packages.props 中央版本一致。
param(
    [string]$DirectoryPackagesPath = ''
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $DirectoryPackagesPath) {
    $DirectoryPackagesPath = Join-Path $repoRoot 'NuGetVerify/Directory.Packages.props'
}

if (-not (Test-Path $DirectoryPackagesPath)) {
    throw "Missing $DirectoryPackagesPath"
}

$content = Get-Content -Path $DirectoryPackagesPath -Raw
$central = @{}
foreach ($m in [regex]::Matches($content, '<PackageVersion\s+Include="([^"]+)"\s+Version="([^"]+)"')) {
    $central[$m.Groups[1].Value] = $m.Groups[2].Value
}

. (Join-Path $PSScriptRoot 'feed-core-pack-versions.ps1')
$coreProjects = Get-SmartentFeedCorePackProjects
$mismatches = @()

foreach ($entry in $coreProjects) {
    if (-not $entry.Version) { continue }
    $id = $entry.PackageId
    if (-not $central.ContainsKey($id)) {
        Write-Output "Skip $id (not in NuGetVerify central packages)."
        continue
    }
    if ($central[$id] -ne $entry.Version) {
        $mismatches += "$id : feed=$($entry.Version) central=$($central[$id])"
    }
}

if ($mismatches.Count -gt 0) {
    Write-Error ("Version drift:`n" + ($mismatches -join "`n"))
    exit 1
}

Write-Output "feed-core-pack-versions aligned with NuGetVerify central versions ($($coreProjects.Count) entries)."
exit 0