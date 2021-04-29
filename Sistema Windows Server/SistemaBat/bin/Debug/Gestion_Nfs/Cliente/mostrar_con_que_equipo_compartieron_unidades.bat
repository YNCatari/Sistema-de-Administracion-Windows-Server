@echo off
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 showmount -e 192.170.30.1 > user.txt
exit
