@echo off
echo listar Unidad Organizativa
echo *********************************
echo.
set /p dom=Escriba el dominio: 
set /p listar=Escribe listar Unidad Organizativa:
dsquery ou "ou=%listar%,dc=%dom%,dc=com"
echo Unidad Organizativa Listado Correctamente
exit