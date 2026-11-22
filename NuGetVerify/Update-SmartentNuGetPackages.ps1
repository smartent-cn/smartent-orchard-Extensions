Update-VisualStudioSolutionNuGetPackages -Path (Get-Location).Path -ProjectNameFilter 'Smartent.*' -PackageNameFilter 'Smartent.*'
Write-Output 'Finished updating packages.'