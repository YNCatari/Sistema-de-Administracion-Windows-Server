@echo off
set /p op=
if %op% == 1 goto op1
if %op% == 2 goto op2
if %op% == 3 goto op3
if %op% == 4 goto op4
if %op% == 5 goto op5
if %op% == 6 goto op6
if %op% == 7 goto op7
if %op% == 8 goto op8
if %op% == 9 goto end

:op1
cls
echo LISTA DE USUARIOS
cd C:\PSTools
echo LISTA DE USUARIOS
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 cmd

exit

:op2
set /p cuenta=
set /p fullname="
echo.
goto pass

	:pass
	set /p pass=
	set /p cam= 
	if %cam% == si goto cam1
	if %cam% == no goto cam2

	:cam1
	set /p camb=
	if %camb% == si goto camb1
	if %camb% == no goto camb2

	:camb1
	cd C:\PSTools
	psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %cuenta% %pass% /add /passwordchg:yes /logonpasswordchg:yes /fullname:"%fullname%"
	exit
	
	:camb2
	cd C:\PSTools
	psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %cuenta% %pass% /add /passwordchg:NO /fullname:"%fullname%"
	exit

	:cam2
	cd C:\PSTools
	psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %cuenta% %pass% /add /passwordchg:NO /fullname:"%fullname%"
	exit

:op3
set /p us=	
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %us% /del
exit

:op4 
cls
set /p us=
echo Detalle
net user %us%
exit

:op5
set /p resp3=
if %resp3% == 1  goto hab
if %resp3% == 2  goto des

	:hab
	set /p us=
	cd C:\PSTools
	psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %us% /active:yes	
	exit

	:des
	set /p us=
	cd C:\PSTools
	psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %us% /active:no
	exit

:op6
set /p nombr=
set /p contra= 
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user "%nombr%" %contra%
exit


:op7
set /p noombrr=
set /p n=
FOR /L %%i IN (1,1,%n%) DO (
set /p equipo%%i=
)
cd C:\PSTools
psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %noombrr% /workstations:%equipo1%,%equipo2%,%equipo3%,%equipo4%,%equipo5%,%equipo6%,%equipo7%,%equipo8%
exit

:op8
set /p nombrr=
set /p oo=
if %oo% == si goto inter
if %oo% == no goto norm

	:inter
	echo.
	set /p dia=Indique primer lote de dias de inicio(L-M-Mi-J-V-S-Do):
	set /p hora=Indique primer lote de horas habiles de inicio de sesion(ejm:10-14):
	echo.
	set /p dia1=Indique segundo lote de dias de inicio(L-M-Mi-J-V-S-Do):
	set /p hora1=Indique segundo lote de horas habiles de inicio de sesion(ejm:10-14):
	net user %nombrr% /times:%dia%,%hora%;%dia1%,%hora1%
	echo.
	echo Asignado exitosamente
	pause > nul
	goto main

	:norm
	
	set /p dia=
	set /p hora=
	cd C:\PSTools
	psexec \\192.170.30.1 -u upt30.com\Administrador -p Sistemas.123 net user %nombrr% /times:%dia%,%hora%
	exit

	
:end
cls
call GESTION.bat