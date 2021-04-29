@echo off
cls
echo ESTADISTICAS DEL SERVIDOR
echo =========================
netsh dhcp server show all
pause > nul
exit
