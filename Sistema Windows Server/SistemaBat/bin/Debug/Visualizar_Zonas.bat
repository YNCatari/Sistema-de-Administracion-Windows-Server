@echo off
cls
echo Visualizar Zonas
echo ================
echo.
echo Get-DnsServerZone > zonas.ps1
powershell.exe -ExecutionPolicy Bypass -File "zonas.ps1"
del zonas.ps1
echo.
pause > nul
exit
