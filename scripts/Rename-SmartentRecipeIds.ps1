# Update Orchard recipe ids and related strings after recipe file renames.
$ErrorActionPreference = 'Stop'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$root = Join-Path $repo 'src'

$replacements = [ordered]@{
    'Lombiq.OSOCE.BasicOrchardFeaturesTests' = 'Smartent.Demo.BasicOrchardFeaturesTests'
    'Lombiq.OSOCE.Tests.FeaturesGuard' = 'Smartent.Demo.Tests.FeaturesGuard'
    'Lombiq.OSOCE.Tests.Elasticsearch' = 'Smartent.Test.UI.Samples.Elasticsearch'
    'Lombiq.OSOCE.Tests' = 'Smartent.Demo.Tests'
    'Lombiq.OSOCE.BaseTheme' = 'Smartent.Demo.BaseTheme'
    'Lombiq.OrchardCoreApiClient.Tests.UI.OpenId' = 'Smartent.Orchard.ApiClient.Tests.UI.OpenId'
    'Lombiq.OrchardCoreApiClient.Tester.OpenId' = 'Smartent.Orchard.ApiClient.Tester.OpenId'
    'UseLombiqTestsUIAdminTheme' = 'UseSmartent.Test.UI.AdminTheme'
    'Lombiq.DataTables.Samples.Content' = 'Smartent.Orchard.DataTables.Samples.Content'
    'Lombiq.ChartJs.Samples.Content' = 'Smartent.Orchard.ChartJs.Samples.Content'
    'Lombiq.UIKit.Widgets.Content' = 'Smartent.Orchard.UIKit.Widgets.Content'
}

$paths = @(
    'Recipes\Lombiq.OSOCE.Tests.Elasticsearch.recipe.json'
    'Recipes\Smartent.Test.UI.Samples.Elasticsearch.recipe.json'
    'Recipes\Lombiq.OrchardCoreApiClient.Tests.UI.OpenId.recipe.json'
    'Recipes\Smartent.Orchard.ApiClient.Tests.UI.OpenId.recipe.json'
)

$dirs = [System.Collections.Generic.Queue[string]]::new()
$dirs.Enqueue($root)
$files = [System.Collections.ArrayList]::new()
while ($dirs.Count -gt 0) {
    $dir = $dirs.Dequeue()
    try {
        foreach ($child in [System.IO.Directory]::EnumerateDirectories($dir)) {
            $name = [System.IO.Path]::GetFileName($child)
            if ($name -in @('bin', 'obj', 'node_modules')) { continue }
            $dirs.Enqueue($child)
        }
        foreach ($child in [System.IO.Directory]::EnumerateFiles($dir)) {
            [void]$files.Add($child)
        }
    } catch { }
}

$files |
    Where-Object {
        $_ -notmatch '\\(bin|obj|node_modules)\\' -and
        ($_ -match '\.(cs|csproj|json|md|sln|slnx)$' -or $_ -like '*.recipe.json')
    } |
    ForEach-Object {
        $content = [System.IO.File]::ReadAllText($_.FullName)
        $original = $content
        foreach ($kv in $replacements.GetEnumerator()) {
            $content = $content.Replace($kv.Key, $kv.Value)
        }
        $content = $content.Replace('Lombiq.OSOCE.Tests.recipe.json', 'Smartent.Demo.Tests.recipe.json')
        $content = $content.Replace('Lombiq.OrchardCoreApiClient.', 'Smartent.Orchard.ApiClient.')
        if ($content -ne $original) {
            [System.IO.File]::WriteAllText($_.FullName, $content)
        }
    }

Write-Host 'Recipe id updates complete.'