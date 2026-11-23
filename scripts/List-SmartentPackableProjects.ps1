# 列出 Smartent-src 中含 PackageId 的可发布 csproj（粗筛，不含 IsPackable=false）。
param(
    [string]$Root = ''
)

$ErrorActionPreference = 'Stop'
if (-not $Root) {
    $Root = Join-Path (Split-Path -Parent $PSScriptRoot) 'Smartent-src'
}

$results = @()
Get-ChildItem -Path $Root -Recurse -Filter '*.csproj' -File | ForEach-Object {
    $text = Get-Content -LiteralPath $_.FullName -Raw
    if ($text -match '<IsPackable>\s*false\s*</IsPackable>') { return }
    if ($text -match '<PackageId>\s*([^<]+)\s*</PackageId>') {
        $id = $Matches[1].Trim()
        $results += [PSCustomObject]@{
            PackageId = $id
            Project   = $_.FullName.Replace((Split-Path -Parent $PSScriptRoot) + [IO.Path]::DirectorySeparatorChar, '')
        }
    }
}

$results | Sort-Object PackageId | Format-Table -AutoSize
Write-Output "Total: $($results.Count)"