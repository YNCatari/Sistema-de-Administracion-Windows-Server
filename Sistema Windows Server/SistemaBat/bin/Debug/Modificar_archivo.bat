@echo off
echo creardirectorio
echo 
dir /a /b
set /p ac=Nombre actual:
echo.
set /p nw=Nuevo nombre:
REN "%ac%" "%nw%"
echo Se cambio el nombre de %ac% por %nw%
echo Agregado Correctamente
exit
