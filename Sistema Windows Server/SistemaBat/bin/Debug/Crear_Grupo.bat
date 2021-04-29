@echo off
set /p opc= 
IF %opc% == 1 goto clocal
IF %opc% == 2 goto cglobal
if %opc% == 3 goto main

:clocal
set /p no=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net localgroup %no% /add
exit

:cglobal
set /p no=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net group %no% /add
exit