@echo off
cd C:\PSTools
psexec \\192.170.28.1 -u Administrador -p Sistemas.123 showmount -e 192.170.28.1 > user.txt
exit
