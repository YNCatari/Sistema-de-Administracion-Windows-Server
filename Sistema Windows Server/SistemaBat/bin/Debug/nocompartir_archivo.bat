@echo off
echo compartir
echo 
net share
set/p nombrenocompartirdir="Nombre del directorio que quiere dejar de compartir: "
net share %nombrenocompartirdir% /delete
exit