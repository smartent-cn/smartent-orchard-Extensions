# You can use this script to reset the app, i.e., it'll run the setup on the next launch again. Execute it only when the
# app is not running.

Remove-Item '.\Smartent.Orchard.TrainingDemo.Web\App_Data' -Recurse -ErrorAction SilentlyContinue
Write-Output 'Successfully reset website.'