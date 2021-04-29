@echo off
hostname
		set /p domain=ingrese dominio:
		echo Add-Computer -DomainName %domain% > bb.ps1
		powershell.exe -ExecutionPolicy Bypass -File "bb.ps1"
		del bb.ps1	
		echo Cambiado exitosamente.. debe reiniciar
		set /p resp=Reiniciar ahora?(si/no):
		if %resp% == si shutdown -r -f -t 5
		if %resp% == no goto op2
exit