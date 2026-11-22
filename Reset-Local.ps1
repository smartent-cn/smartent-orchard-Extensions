# Resets Orchard App_Data for the Smartent demo web host.
Remove-Item '.\Smartent-src\Demo\Smartent.Demo.Web\App_Data' -Recurse -Force -ErrorAction SilentlyContinue
Write-Output 'Successfully reset Smartent.Demo.Web App_Data.'