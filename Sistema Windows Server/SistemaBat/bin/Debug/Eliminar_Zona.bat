@echo off
cls
echo Eliminar Zona
echo =============
echo.
set /p nombre=Ingrese nombre de zona a eliminra: 
echo Remove-DnsServerZone "%nombre%" -PassThru -Verbose > eli.ps1
powershell.exe -ExecutionPolicy Bypass -File "eli.ps1"
del eli.ps1
echo.
echo Eliminado correctamente...
pause > nul
exit
