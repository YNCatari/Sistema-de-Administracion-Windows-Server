@echo off
cls
set /p oppp=
if %oppp% == 1 goto ip4
if %oppp% == 2 goto ip6
if %oppp% == 3 goto main 

:ip4
set /p k=
set /p l=
set /p i=
set /p j=
set /p n=
set /p o=
set /p m=
set /p dns1=
set /p dominio=
set /p resp=
if %resp% == si goto excl
if %resp% == no goto crr

:crr
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server add scope %k% %l% "%i%" "%j%"
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server Scope %k% add iprange %n% %o%
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server Scope %k% set optionvalue 3 IPADDRESS "%m%"
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server Scope %k% set state 1
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server set optionvalue 6 IPADDRESS "%dns1%"
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server set optionvalue 15 STRING "%dominio%"
exit

:excl
set /p excl1= 
set /p excl2=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server add scope %k% %l% "%i%" "%j%"
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server Scope %k% add iprange %n% %o%
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server scope %k% add excluderange %excl1% %excl2%
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server Scope %k% set optionvalue 3 IPADDRESS "%m%"
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server Scope %k% set state 1
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server set optionvalue 6 IPADDRESS "%dns1%"
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh Dhcp Server set optionvalue 15 STRING "%dominio%"
exit