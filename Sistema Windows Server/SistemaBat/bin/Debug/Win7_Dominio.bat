@echo off
set /p dom=Ingrese dominio: 
		set /p us=Ingrese Usuario: 	
		
		echo add-computer -credential %dom%\%us% -DomainName %dom%.com > b.ps1
		powershell.exe -ExecutionPolicy Bypass -File "b.ps1"
		del b.ps1
		echo Cambiado exitosamente.. debe reiniciar
		set /p resp=Reiniciar ahora?(si/no):
		if %resp% == si shutdown -r -f -t 2
		if %resp% == no goto op2
exit