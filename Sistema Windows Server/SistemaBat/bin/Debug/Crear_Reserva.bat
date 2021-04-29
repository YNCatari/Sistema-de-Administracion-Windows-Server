@echo off
cls
set /p am=
set /p res=
set /p ma=
set /p nom=
set /p desc=
set /p tip=

cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server scope %am% add reservedip %res% %ma% "%nom%" "%desc%" %tip%

exit