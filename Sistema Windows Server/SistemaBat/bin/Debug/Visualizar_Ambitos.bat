@echo off
cls
echo AMBITO IPv4
echo ===========
echo. 
netsh dhcp server v4 show scope
pause > nul
exit
