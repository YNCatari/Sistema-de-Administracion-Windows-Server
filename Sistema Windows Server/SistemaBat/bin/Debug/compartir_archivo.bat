@echo off
echo compartir
echo 
set/p ruta="La ruta en la que esta su archivo por ejemplo : E "
set/p nombredirshare="Como se llamara tu carpeta compartida: "
set/p carpetadirshare="Como se llama la carpeta que compartira: "
net share %nombredirshare%=%ruta%:\%carpetadirshare%
exit