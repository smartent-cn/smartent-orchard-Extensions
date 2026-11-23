# 在 NuGetVerify 目录下运行：仅更新 Smartent.* 中央版本（Visual Studio 解决方案 NuGet 工具）。
# Run from NuGetVerify: bumps Smartent.* package versions in central management.
Update-VisualStudioSolutionNuGetPackages -Path (Get-Location).Path -ProjectNameFilter 'Smartent.*' -PackageNameFilter 'Smartent.*'
Write-Output 'Finished updating packages.'