@echo off
set /p nombre=Ingrese el nombre/IP del servidor:  
set /p zona=Ingresa el nombre de la nueva zona: 
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 dnscmd %nombre% /zoneadd %zona% /DsPrimary
exit
