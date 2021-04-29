@echo off
echo Eliminar una Unidad Organizativa
echo *********************************
echo.
set /p dom=Escriba el dominio: 
set /p eliminar=Escribe Actual Unidad Organizativa:
dsrm -subtree -noprompt -c  "ou=%eliminar%,dc=%dom%,dc=com"
echo Unidad Organizativa Eliminado Correctamente
exit