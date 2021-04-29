@echo off
set /p k=
set /p excl1=
set /p excl2=

cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server scope %k% add excluderange %excl1% %excl2%
exit