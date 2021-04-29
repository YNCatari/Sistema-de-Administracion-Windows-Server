@echo off
set /p nombre= 
set /p new=
netsh interface set interface name="%nombre%" newname="%new%"
			
exit