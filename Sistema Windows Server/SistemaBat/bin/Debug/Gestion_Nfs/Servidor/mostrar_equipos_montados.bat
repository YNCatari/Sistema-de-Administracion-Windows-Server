@echo off
cd C:\PSTools
psexec \\192.170.28.1 -u Administrador -p Sistemas.123 showmount -a 192.170.28.1 > user.txt
exit
