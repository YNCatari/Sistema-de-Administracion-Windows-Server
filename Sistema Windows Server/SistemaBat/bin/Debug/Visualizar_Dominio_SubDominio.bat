@echo off
cls
echo Crear, Eliminar Sub Dominios
echo =============================
echo.
echo 1.-Visualizar Dominios
echo 2.-Visualizar Subdominios
echo 3.-Regresra
echo.
set /p opic=Ingrese opcion valida: 
if %opic% == 1 goto opic1 
if %opic% == 2 goto opic2 
if %opic% == 3 goto opic3

:opic1
echo Visualizar Dominios
echo ===================
echo.
set /p name=Ingrese nombre de zona a visualizar: 
echo Get-DnsServerResourceRecord -ZoneName "%name%" -RRType "A" > vis.ps1
powershell.exe -ExecutionPolicy Bypass -File "vis.ps1"
del vis.ps1
pause > nul
goto main

:opic2
cls
echo Visualizar SUB-Dominios
echo ===================
echo.
set /p name=Ingrese nombre de zona a visualizar: 
echo Get-DnsServerResourceRecord -ZoneName "%name%" -RRType "A" > vis.ps1
powershell.exe -ExecutionPolicy Bypass -File "vis.ps1"
del vis.ps1
pause > nul
exit
