# 在 core 本地 feed 下，模拟独立 NuGetVerify 的 PackageReference 还原（不走 monorepo Sdk）。
param(
    [switch]$SkipPack,
    [string]$Configuration = 'Release'
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$nugetVerify = Join-Path $repoRoot 'NuGetVerify'
$localConfig = Join-Path $nugetVerify 'NuGet.config.local'
$exampleConfig = Join-Path $nugetVerify 'NuGet.config.local.example'

if (-not (Test-Path $localConfig)) {
    Copy-Item $exampleConfig $localConfig
    Write-Output "Created $localConfig from example."
}

if (-not $SkipPack) {
    & (Join-Path $PSScriptRoot 'Pack-SmartentLocalFeed.ps1')
    if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
}

$projects = @(
    'test/Smartent.NuGet.Tests/Smartent.NuGet.Tests.csproj',
    'src/Modules/Smartent.NuGet.TestModule/Smartent.NuGet.TestModule.csproj',
    'src/Themes/Smartent.NuGet.TestTheme/Smartent.NuGet.TestTheme.csproj'
)
# Tests 还原可能仍缺 Platform 传递依赖；未绿时可先验 Module/Theme，或 expansion core pack / -Full。

$env:NUGET_PACKAGES = "$env:USERPROFILE\.nuget\packages"
Push-Location $nugetVerify
try {
    foreach ($rel in $projects) {
        Write-Output "Restoring (standalone) $rel ..."
        dotnet restore $rel --configfile $localConfig -p:Configuration=$Configuration -p:ForceStandaloneNuGetVerify=true
        if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }
    }
    Write-Output 'Core PackageReference restore succeeded.'
}
finally {
    Pop-Location
}