@echo off
set /p op= 
if %op% == 1 goto op1
if %op% == 2 goto op2
if %oP% == 3 goto main

:op1
set /p nombre=
set /p zona=
set /p ip2=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 dnscmd %nombre% /zoneadd %zona% /secondary %ip2%
exit

:op2
echo.
set /p nombre=
set /p zona=
set /p ip2=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 dnscmd %nombre% /zoneadd %zona% /Forwarder %ip2%
exit
