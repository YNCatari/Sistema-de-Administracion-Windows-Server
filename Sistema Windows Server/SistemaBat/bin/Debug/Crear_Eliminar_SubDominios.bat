@echo off
cls
echo Crear, Eliminar Sub Dominios
echo =============================
echo.
echo 1.-Crear Subdominio
echo 2.-Eliminar Subdominio
echo 3.-Regresra
echo.
set /p opic=Ingrese opcion valida: 
if %opic% == 1 goto opic1 
if %opic% == 2 goto opic2 
if %opic% == 3 goto opic3

:opic1
set /p domin=Ingrese nombre del dominio: 
set /p nombre=Ingrese nombre de la zona: 
set /p ip=Ingrese el ip de su dominio: 
echo Add-DnsServerResourceRecordA -Name "%domin%" -ZoneName "%nombre%" -AllowUpdateAny -IPv4Address "%ip%" > crear.ps1
powershell.exe -ExecutionPolicy Bypass -File "crear.ps1"
del crear.ps1
echo.
echo Creado exitosamente...
pause > nul
goto main

:opic2
set /p domin=Ingrese nombre del dominio: 
set /p nombre=Ingrese nombre de la zona: 
set /p ip=Ingrese el ip de su dominio: 
echo Remove-DnsServerResourceRecord -ZoneName "%nombre%" -RRType "A" -Name "%domin%" -RecordData "%ip%" > crear.ps1
powershell.exe -ExecutionPolicy Bypass -File "crear.ps1"
del crear.ps1
echo.
echo Elminado Correctamente...
pause > nul 
exit
