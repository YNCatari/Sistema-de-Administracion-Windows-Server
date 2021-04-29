@echo off
set /p opi=
if %opi% == 1 goto dlocal
if %opi% == 2 goto dglobal
if %opi% == 3 goto main

:dlocal
set /p nomm=
set /p us=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net localgroup %nomm% %us% /del
exit

:dglobal
set /p nomm=
set /p us=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net group %nomm% %us% /del
exit