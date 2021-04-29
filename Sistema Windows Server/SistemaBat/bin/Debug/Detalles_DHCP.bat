@echo off
cls
echo DETALLES DE SERVIDOR
echo ====================
echo.
netsh dhcp show server
pause > nul
exit