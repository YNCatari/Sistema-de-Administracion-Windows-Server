@echo off
hostname
		set /p nom=Ingrese nombr de pc: 
		set /p dom=Ingrese dominio: 
		set /p us=Ingrese Usuario: 
		set /p con=Ingrese contraseña: 	
		netdom join %nom% /Domain:%dom% /UserD:%us% /PasswordD:%con%	
		echo Cambiado exitosamente.. debe reiniciar
		set /p resp=Reiniciar ahora?(si/no):
		if %resp% == si shutdown -r -f -t 5
		if %resp% == no goto op2
exit