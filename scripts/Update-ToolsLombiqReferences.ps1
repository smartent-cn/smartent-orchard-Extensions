# Bulk text update after tools project renames. Does not touch Lombiq/GitHub-Actions@ refs.
$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path

$replacements = [ordered]@{
    'Lombiq.Analyzers.VisualStudioExtension' = 'Smartent.Build.Analyzers.VisualStudioExtension'
    'Lombiq.Analyzers.OrchardCore'           = 'Smartent.Build.Analyzers.OrchardCore'
    'Lombiq.Analyzers.Orchard1'              = 'Smartent.Build.Analyzers.Orchard1'
    'Lombiq.Analyzers.NetFx'                 = 'Smartent.Build.Analyzers.NetFx'
    'Lombiq.Analyzers.PowerShell'            = 'Smartent.Build.Analyzers.PowerShell'
    'Lombiq.Analyzers.PackageReference'       = 'Smartent.Build.Analyzers.PackageReference'
    'Lombiq.Analyzers.ProjectReference'      = 'Smartent.Build.Analyzers.ProjectReference'
    'Lombiq.Analyzers'                       = 'Smartent.Build.Analyzers'
    'Lombiq.GitHub.Actions'                  = 'Smartent.GitHub.Actions'
}

$ext = '\.(csproj|props|targets|sln|slnx|md|yml|yaml|xml|json|json5|ps1|sh|psd1|psm1|globalconfig|template|cfg|txt|cs|editorconfig|gitmodules)$'

function Get-RepoFiles([string]$root) {
    $dirs = [System.Collections.Generic.Queue[string]]::new()
    $dirs.Enqueue($root)
    $files = [System.Collections.ArrayList]::new()
    while ($dirs.Count -gt 0) {
        $dir = $dirs.Dequeue()
        try {
            foreach ($child in [System.IO.Directory]::EnumerateDirectories($dir)) {
                $name = [System.IO.Path]::GetFileName($child)
                if ($name -in @('.git', 'bin', 'obj', 'node_modules', 'artifacts', '.vs')) { continue }
                $dirs.Enqueue($child)
            }
            foreach ($child in [System.IO.Directory]::EnumerateFiles($dir)) {
                [void]$files.Add($child)
            }
        } catch { Write-Warning "Skip $dir" }
    }
    return $files
}

Get-RepoFiles $repo |
    ForEach-Object {
        try { Get-Item -LiteralPath $_ -ErrorAction Stop } catch { return }
    } | Where-Object { $_ } |
    Where-Object {
        $_.Name -in @('.codespellrc', 'Directory.Build.props', 'Directory.Packages.props', 'trunk.yaml') -or
        $_.FullName -match $ext
    } |
    Where-Object { $_.FullName -notmatch '\\scripts\\(Rename|Update)-ToolsLombiq' } |
    ForEach-Object {
        $content = [System.IO.File]::ReadAllText($_.FullName)
        $original = $content
        foreach ($kv in $replacements.GetEnumerator()) {
            $content = $content.Replace($kv.Key, $kv.Value)
        }
        if ($content -ne $original) {
            [System.IO.File]::WriteAllText($_.FullName, $content)
        }
    }

Write-Host 'Reference update complete.'