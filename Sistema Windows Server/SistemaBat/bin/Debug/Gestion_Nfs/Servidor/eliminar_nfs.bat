@echo off
set /p i= 
cd C:\PSTools
psexec \\192.170.28.1 -u Administrador -p Sistemas.123 nfsshare %i% /del
exit
