@echo off
title Gestion pc_Cliente_win8_10

:main
cls
set /p op=
if %op% == 1 goto op1
if %op% == 2 goto op2
if %op% == 3 goto end

	:op1	
	set /p opc=
	if %opc% == 1 goto opc1
	if %opc% == 2 goto opc2
	if %opc% == 3 goto main

		:opc1
		cls
		echo Ver propiedades de adaptador
		echo ============================
		echo.
		echo 1.-Simple
		echo 2.-Detallada
		echo 3.-Adaptador en particular
		echo 4.-Regresar
		echo.
		set /p opci=Ingrese opcion:
		if %opci% == 1 goto opci1
		if %opci% == 2 goto opci2
		if %opci% == 3 goto opci3
		if %opci% == 4 goto op1

			:opci1
			cls
			echo Vista Simple
			echo =============
			echo.
			ipconfig
			pause > nul
			goto opc1

			:opci2
			cls
			echo Vista Detallada
			echo =============
			echo.
			ipconfig /all
			pause > nul
			goto opc1

			:opci3
			cls
			echo Adaptador en particular
			echo =======================
			echo.
			echo ==================================================================================
			ipconfig
			echo.
			echo ==================================================================================
			echo.
			set /p nombre=INGRESE NOMBRE DEL ADAPTADOR A VISUALIZAR:
			netsh interface ipv4 show addres %nombre%
			netsh interface ipv4 show dns %nombre%
			pause > nul
			goto opc1

		:opc2
		cls
		set /p opcio=
		if %opcio% == 1 goto opcio1
		if %opcio% == 2 goto opcio2
		if %opcio% == 3 goto opcio3
		if %opcio% == 4 goto main

			:opcio1
			cls
			echo Asignar manualmente
			echo ==================================================================================
			ipconfig
			echo.
			echo ==================================================================================
			echo.
			set /p nombre=INGRESE NOMBRE DEL ADAPTADOR A MODIFICAR:
			set /p ip=Ingrese la ip:
			set /p mas=Ingrese la mascara:
			set /p puer=Ingrese la puerta de enlace:
			set /p dns=Ingrese el DNS primario:
			set /p dns2=Ingrese el DNS secundario:
			netsh interface ip set address name="%nombre%" static %ip% %mas% %puer% 
			netsh interface ip set dns name="%nombre%" static %dns% primary
			netsh interface ip set dns name="%nombre%" static %dns2% secondary
			echo.
			echo Proceso terminado
			pause > nul
			goto opc2

			:opcio2			
			set /p nombre=
			netsh interface ip set address "%nombre%" source=dhcp
			exit
			

			:opcio3
			cls
			echo ADAPTADORES DE RED ACTUALES
			echo ===========================
			echo.
			netsh interface show interface
			echo.
			set /p nombre=Ingrese el nombre del adaptador a cambiar: 
			set /p new=Ingrese el nuevo nombre: 
			netsh interface set interface name="%nombre%" newname="%new%"
			echo Nombre cambiado exitosamente...
			pause > nul
			goto opc2

	:op2
	cls
	echo Gestion de PC
	echo =============
	echo.
	echo 1.-Visualizar Nombre de Equipo
	echo 2.-Cambiar Nombre de Equipo
	echo 3.-Ver nombre de Grupo de trabajo o dominio
	echo 4.-Cambiar nombre de Grupo de Trabajo o dominio
	echo 5.-Regresar
	echo.
	set /p o=Ingrese opcion:
	if %o% == 1 goto o1
	if %o% == 2 goto o2
	if %o% == 3 goto o3
	if %o% == 4 goto o4
	if %o% == 5 goto main

		:o1
		echo.
		echo El nombre del equipo es:
		hostname
		echo ------------------------
		pause > nul
		goto op2

		:o2
		cls
		echo Cambiar nombre de equipo
		echo ========================
		echo.
		set /p nombree=Ingrese nuevo nombre de equipo:
		set /p resp=Esta seguro con el nuevo nombre?:(si/no):
		if %resp% == si goto resp1
		if %resp% == no goto o2

			:resp1
			WMIC.exe ComputerSystem where Name="%COMPUTERNAME%" call Rename Name=%nombree%
            echo.
		    echo Cambiado exitosamente (es necesario reiniciar para aplicar cambios)
		    set /p resp=Reiniciar ahora?(si/no):
		    if %resp% == si shutdown -r -f -t 10
		    if %resp% == no goto op2
		

		:o3
		cls 
		echo Grupos de trabajo/dominio
		echo ==========================
		echo.
		echo 1.-Trabajo
		echo 2.-Dominio
		echo 3.-Regresar
		echo.
		set /p k=Ingrese opcion valida: 
		if %k% == 1 net view
		if %k% == 2 net config workstation
		if %k% == 3 goto op2
		pause > nul
		goto op2

		:o4
		cls 
		echo Cambiar nombre de grupo de trabajo/dominio
		echo ==========================================
		echo.
		echo 1.-Workgroup
		echo 2.-Dominio
		echo 3.-Regresar
		echo.
		set /p op=Ingrese opcion: 
		if %op% == 1 goto workg	
		if %op% == 2 goto domm
		if %op% == 3 goto op2
		
		:workg
		set /p grupo=Ingrese nombre de grupo:
		wmic computersystem where name="%computername%" call joindomainorworkgroup name=%grupo%
		echo.
		echo Cambiado exitosamente (es necesario reiniciar para aplicar cambios)
		set /p resp=Reiniciar ahora?(si/no):
		if %resp% == si shutdown -r -f -t 10
		if %resp% == no goto op2


		:domm
		hostname
		set /p domain=ingrese dominio:
		echo Add-Computer -DomainName %domain% > bb.ps1
		powershell.exe -ExecutionPolicy Bypass -File "bb.ps1"
		del bb.ps1	
		echo Cambiado exitosamente.. debe reiniciar
		set /p resp=Reiniciar ahora?(si/no):
		if %resp% == si shutdown -r -f -t 5
		if %resp% == no goto op2
		

:end
cls
call GESTION.bat

