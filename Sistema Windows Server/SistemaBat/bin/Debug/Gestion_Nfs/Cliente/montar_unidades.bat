@echo off
set /p opi= 
if %opi% == 1 goto opi1
if %opi% == 2 goto opi2
if %opi% == 3 goto opi3
if %opi% == 4 goto main

:opi1
set /p ip=Ingrese ip del servidor: 
showmount -e %ip%
echo.
set /p nom=Ingrese nombre a montar: 
mount \\%ip%\%nom% *
pause > nul
goto opcion8

:opi2
echo.
set /p nom=
set /p u=
mount \\192.170.30.1\%nom% %u%:
exit


:opi3
set /p ip=Ingrese ip del servidor: 
showmount -e %ip%
echo.
set /p nom=Ingrese nombre a montar: 
set /p u=Ingrese letra de la unidad: 
mount -o anon,Fileaccess777,casesensitive \\%ip%\%nom% %u%:
pause > nul
