@echo off
echo creardirectorio
echo 
set /p nombredir="Ingrese el nombre del directorio :"
md %nombredir%
dir /a /b
echo Agregado Correctamente
exit


