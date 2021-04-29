@echo off
set /p opp=
if %opp% == 1 goto act
if %opp% == 2 goto desc
if %opp% == 3 goto main

:act 
set /p am=
set /p ipp=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server %ipp% scope %am%  set state 1
exit

:desc
netsh
set /p am=
set /p ipp=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server %ipp% scope %am%  set state 0
exit