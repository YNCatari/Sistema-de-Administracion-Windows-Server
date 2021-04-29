@echo off
set /p opi=
if %opi% == 1 goto elocal
if %opi% == 2 goto eglobal
if %opi% == 3 goto main

:elocal
set /p nomm=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net localgroup %nomm% /del
exit

:eglobal
set /p nomm=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net group %nomm% /del
exit