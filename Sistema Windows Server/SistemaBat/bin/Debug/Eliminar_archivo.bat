@echo off
echo eliminardirectorio
echo 
dir /a /b
set/p eliminardir="Que directorio desea eliminar: "
rmdir /s /q %eliminardir%  
echo Se elimino %eliminardir%
echo Agregado Correctamente
exit