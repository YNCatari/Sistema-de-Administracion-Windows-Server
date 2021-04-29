@echo off
cls
set /p ipp=
set /p res=
set /p ma=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server scope %ipp% delete reservedip %res% %ma%
exit