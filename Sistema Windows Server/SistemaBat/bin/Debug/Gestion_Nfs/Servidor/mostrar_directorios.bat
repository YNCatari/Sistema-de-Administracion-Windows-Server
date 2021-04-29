@echo off
cd C:\PSTools
psexec \\192.170.28.1 -u Administrador -p Sistemas.123 diskpart -s C:\PSTools\list.txt > user.txt
exit
