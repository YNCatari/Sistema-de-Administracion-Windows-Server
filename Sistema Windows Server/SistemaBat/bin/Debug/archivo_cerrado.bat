@echo off
echo archivo cerrado
echo 
net file
set/p idd="Digite el id que quiere cerrar: "
net file %idd% /close 
exit