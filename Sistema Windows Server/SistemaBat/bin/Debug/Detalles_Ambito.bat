@echo off
cls
echo DETALLES DE AMBITO
echo ==================
netsh dhcp server show scope
set /p ipp=Ingrese ip del ambito a visualizar:
cls
echo ------------------------------------------------------------------------------------------
echo RANGO DE IP's
netsh dhcp server scope %ipp% show iprange 
echo ------------------------------------------------------------------------------------------
echo.
echo.
echo RANGO EXCLUIDOS
netsh dhcp server scope %ipp% show excluderange
echo ------------------------------------------------------------------------------------------
echo.
echo.
echo IP RESERVADOS
netsh dhcp server scope %ipp% show reservedip
echo ------------------------------------------------------------------------------------------
pause > nul
exit