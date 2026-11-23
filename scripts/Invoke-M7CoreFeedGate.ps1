# M7 本地 feed 聚合门禁：pack → verify → 独立还原 → Monorepo sln 构建。
param(
    [switch]$SkipPack,
    [switch]$WhatIf
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot

& (Join-Path $PSScriptRoot 'Assert-FeedCorePackVersions.ps1')
if (-not $?) { exit 1 }

if ($WhatIf) {
    & (Join-Path $PSScriptRoot 'Pack-SmartentLocalFeed.ps1') -WhatIf
    Write-Output 'WhatIf: Test-NuGetVerifyCorePackageRestore -SkipPack'
    Write-Output 'WhatIf: dotnet build NuGetVerify/Smartent.NuGet.Monorepo.sln -c Release'
    exit 0
}

if (-not $SkipPack) {
    & (Join-Path $PSScriptRoot 'Pack-SmartentLocalFeed.ps1')
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}
else {
    & (Join-Path $PSScriptRoot 'Verify-SmartentLocalFeed.ps1')
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

& (Join-Path $PSScriptRoot 'Test-NuGetVerifyCorePackageRestore.ps1') -SkipPack
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }

$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
dotnet build (Join-Path $repoRoot 'NuGetVerify/Smartent.NuGet.Monorepo.sln') -c Release
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }

$targetsTests = Join-Path $repoRoot 'Smartent-src/Build/Smartent.Build.Targets.Tests/Smartent.Build.Targets.Tests.csproj'
dotnet test $targetsTests -c Release
exit $LASTEXITCODE