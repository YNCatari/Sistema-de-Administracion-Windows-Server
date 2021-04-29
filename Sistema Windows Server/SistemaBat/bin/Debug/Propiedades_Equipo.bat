@echo off
echo Propiedades de Equipo
echo ======================
dsquery computer
set /p nombre=Ingrese Nombre de Equipo: 
set /p dominio=Ingrese dominio: 
set /p extension=Ingrese extension: 
set /p compu=Ingrese directorio: 
dsget computer "CN=%nombre%,CN=%compu%,DC=%dominio%,DC=%extension%" -desc -dn -samid -sid -loc
exit