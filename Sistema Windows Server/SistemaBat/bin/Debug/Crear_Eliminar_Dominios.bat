@echo off
cls
echo CREAR, ELIMINAR DOMINIOS
echo =========================
echo.
echo 1.-Crear
echo 2.-Eliminra
echo 3.-Regresar
echo.
set /p opi=Ingrese opcion valida: 
if %opi% == 1 goto opi1
if %opi% == 2 goto opi2
if %opi% == 3 goto main

:opi1
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

:opi2
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
