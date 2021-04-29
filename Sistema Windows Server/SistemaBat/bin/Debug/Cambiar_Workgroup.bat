@echo off
set /p grupo=Ingrese nombre de grupo:
		wmic computersystem where name="%computername%" call joindomainorworkgroup name=%grupo%
		echo.
		echo Cambiado exitosamente (es necesario reiniciar para aplicar cambios)
		set /p resp=Reiniciar ahora?(si/no):
		if %resp% == si shutdown -r -f -t 10
		if %resp% == no goto op2

exit