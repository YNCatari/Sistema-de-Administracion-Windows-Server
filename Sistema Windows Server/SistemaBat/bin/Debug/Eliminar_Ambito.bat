@echo off
set /p am=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 netsh dhcp server 192.170.30.1 delete scope %am% DHCPFULLFORCE
exit