@echo off
set/p nom=
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net computer \\%nom% /del
exit