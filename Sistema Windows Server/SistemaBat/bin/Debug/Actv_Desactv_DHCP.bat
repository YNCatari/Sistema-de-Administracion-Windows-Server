@echo off
set /p op=
if %op% == 1 goto aut
if %op% == 2 goto desaut

:aut
set /p nom=
set /p ipp=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp add server %nom% %ipp%
exit


:desaut
set /p nom=
set /p ipp=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp delete server %nom% %ipp%
exit