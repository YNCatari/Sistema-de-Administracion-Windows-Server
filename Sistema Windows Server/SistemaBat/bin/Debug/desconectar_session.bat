@echo off
echo desconectarusuarios
echo 
set/p nombreequiponet="Nombre del equipo que quiere desconectar: "
net session \\%nombreequiponet% /delete
echo Agregado Correctamente
exit
