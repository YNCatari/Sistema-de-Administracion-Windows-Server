@echo off
set /p opi=
if %opi% == 1 goto alocal
if %opi% == 2 goto aglobal
if %opi% == 3 goto main

:alocal
set /p nomm=
set /p us=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net localgroup %nomm% %us% /add 
exit

:aglobal
set /p nomm=
set /p us=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net group %nomm% %us% /add 
exit