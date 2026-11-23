# 将本地 feed 中的 MSBuild Sdk nupkg 解压到 ~/.nuget/packages，供 Sdk= 还原（无需上 nuget.org）。
param(
    [string]$FeedPath = '',
    [string[]]$PackageIds = @(
        'Smartent.Build.OrchardCore.Module.Sdk',
        'Smartent.Build.OrchardCore.Theme.Sdk',
        'Smartent.Build.OrchardCore.Tests.Sdk'
    ),
    [string]$Version = '2.1.1'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
if (-not $FeedPath) {
    $FeedPath = Join-Path $repoRoot 'artifacts/smartent-nuget-local'
}

foreach ($id in $PackageIds) {
    $nupkg = Join-Path $FeedPath "$id.$Version.nupkg"
    if (-not (Test-Path $nupkg)) { throw "Missing $nupkg" }
    $dest = Join-Path $env:USERPROFILE ".nuget/packages/$($id.ToLowerInvariant())/$Version"
    if (Test-Path $dest) { Remove-Item -Recurse -Force $dest }
    New-Item -ItemType Directory -Force -Path $dest | Out-Null
    tar -xf $nupkg -C $dest
    Write-Output "Seeded $id $Version -> $dest"
}