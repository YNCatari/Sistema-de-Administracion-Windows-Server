@echo off
cd C:\Windows\System32\inetsrv
appcmd.exe set config "roby.pe" -section:system.webServer/directoryBrowse /enabled:"True" /showFlags:"Date, Time, Size, Extension"
pause
exit