@echo off
echo Crear nuevo Unidad Organizativa
echo *********************************
echo.
set /p dom=Escriba el dominio: 
set /p nueva=Escribe una Nueva Unidad Organizativa: 
dsadd ou "ou=%nueva%,dc=%dom%,dc=com"
exit