@echo off
title GESTION NFS

:main
cls
echo Gestion NFS
echo ===========
echo.
echo 1.-Iniciar/Detener el servidor NFS
echo 2.-Compartir/Asignar permisos carpetas con NFS /equipos
echo 3.-Eliminar Carpetas NFS
echo 4.-Mostrar Carpetas compartidas con NFS
echo 5.-Mostrar equipos que han montado las unidades compartidas
echo 6.-Mostrar con que equipo se han compartido las unidades
echo 7.-Mostrar unidades montadas
echo 8.-Regresar
echo.
set /p opcion=Ingrese opcion valida: 

if %opcion% == 1 goto opcion1
if %opcion% == 2 goto opcion2
if %opcion% == 3 goto opcion3
if %opcion% == 4 goto opcion4
if %opcion% == 5 goto opcion5
if %opcion% == 6 goto opcion6
if %opcion% == 7 goto opcion7
if %opcion% == 8 goto end

:opcion1
cls
echo Iniciar/detener servicio
echo ========================
echo.
echo 1.-Iniciar
echo 2.-Detener
echo 3.-Regresar
echo.
set /p opcion=Ingrese opcion valida: 

if %opcion% == 1 nfsadmin server localhost start
if %opcion% == 2 nfsadmin server localhost stop
if %opcion% == 3 goto main
pause > nul
goto opcion1

:opcion2
cls
echo Compartir/Asignar permisos con carpetas NFS
echo ===========================================
echo.
echo list volume > list.txt
diskpart -s "list.txt"
del list.txt
echo.
set /p d=Ingrese la letra de volumen:  
%d%:
dir
echo.
set /p dir=Que directorio desea compartir?: 
set /p nom=Ingrese nombre: 
set /p pc=Asignar equipos especificos? (si/no): 
if %pc% == si goto resp1
if %pc% == no goto resp3

:resp3
set /p p=Asigne permisos "(1)Solo lectura (2)Lectura escritura (3)Negar acceso": 
if %p% == 1 goto sle
if %p% == 2 goto le
if %p% == 3 goto na

:resp1
dsquery computer
set /p n=Cuantos equipos desea asignar?(max 8):
FOR /L %%i IN (1,1,%n%) DO (
set /p pc%%i=Ingrese nombre de equipo %%i:
)
echo.
set /p p=Asigne permisos "(1)Solo lectura (2)Lectura escritura (3)Negar acceso": 
if %p% == 1 goto sle2
if %p% == 2 goto le2
if %p% == 3 goto na2

:sle2
nfsshare %nom%=%d%:\%dir% -o ro=%pc1%:%pc2%:%pc3%:%pc4%:%pc5%:%pc6%
nfsshare %nom% -o na
pause>nul
goto main

:le2
nfsshare %nom%=%d%:\%dir% -o rw=%pc1%:%pc2%:%pc3%:%pc4%:%pc5%:%pc6%
nfsshare %nom% -o na
pause>nul
goto main

:na2
nfsshare %nom%=%d%:\%dir% -o na=%pc1%:%pc2%:%pc3%:%pc4%:%pc5%:%pc6%
nfsshare %nom% -o na
pause>nul
goto main


:resp2
if %p% == 1 goto sle
if %p% == 2 goto le
if %p% == 3 goto na

:sle
nfsshare %nom%=%d%:\%dir% -o ro
pause>nul
goto main

:le
nfsshare %nom%=%d%:\%dir% -o rw
pause>nul
goto main

:na
nfsshare %nom%=%d%:\%dir% -o na
pause>nul
goto main

:opcion3
cls
echo Eliminar Carpetas compartidas NFS
echo =================================
echo.
nfsshare
echo.
set /p i=Ingrele nombre: 
set /p j=Esta seguro (si/no): 
if %j% == si goto con
if %j% == no goto main

:con
nfsshare %i% /del
pause > nul
goto main

:opcion4
cls
echo Unidades Compartidas NFS
echo =========================
nfsshare
pause > nul
goto main

:opcion5
cls
echo Equipos que han montado unidades compartidas NFS
echo =================================================
echo.
showmount -a 
pause > nul
goto main

:opcion6
cls
echo Equipos permitidos a las unidades compartidas NFS
echo =================================================
echo.
showmount -e
pause > nul
goto main

:opcion7
cls
echo Unidades montadas NFS
echo ======================
echo.
showmount -d 
pause > nul
goto main

:end
cls
GESTION.bat
