@echo off
cls
echo CONCESIONES DE DIRECCIONES IP
echo =============================
netsh dhcp server show scope
set /p am=Ingrese ambito a visualizar: 
cls
echo CONCECIONES IP DEL AMBITO %am%
echo ============================================
netsh dhcp server scope %am% show clients 1
pause > nul
exit
