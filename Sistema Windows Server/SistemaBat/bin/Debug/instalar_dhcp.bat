@echo off 
:Menu
echo ============================
echo Bienvenido al Menu Principal
echo ============================
echo 1.- VERIFICAR DHCP
echo 2.- INSTALAR DHCP
echo 3.- SALIR
echo ============================
echo Elija una opcion (1-3)
set /p opcion=
if %opcion% == 1 goto opcion1
if %opcion% == 2 goto opcion2
if %opcion% == 3 goto opcion3
:opcion1
echo Get-WindowsFeature -Name dhc*>VDHCP.ps1
powershell.exe -ExecutionPolicy Bypass -File "VDHCP.ps1"
del VDHCP.ps1
pause
cls
goto Menu
:opcion2
echo Install-WindowsFeature DHCP -IncludeManagementTools>IDHCP.ps1
powershell.exe -ExecutionPolicy Bypass -File "IDHCP.ps1"
del IDHCP.ps1
pause
cls
goto Menu
:opcion3
exit