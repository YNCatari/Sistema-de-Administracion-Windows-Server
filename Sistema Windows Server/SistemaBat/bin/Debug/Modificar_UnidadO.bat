@echo off
echo Modificar una Unidad Organizativa
echo *********************************
echo.
echo Ingrese el nombre de la Unidad Organizativa en donde se encuentra y desea modificar:
set /p nombre1=
echo Ingrese el nombre de la Unidad Organizativa que desea modificar:
set /p nombre=
echo Ingrese el nuevo nombre que desea cambiar:
set /p nnombre=
echo Rename-ADObject "OU=%nombre%,OU=%nombre1%,DC=upt16,DC=com" -NewName %nnombre%>archivotemporal.ps1
powershell.exe -ExecutionPolicy Bypass -File "archivotemporal.ps1"
del archivotemporal.ps1
echo Se modifico el nombre con exito!
exit