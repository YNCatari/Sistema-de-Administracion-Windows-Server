@echo off
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
exit