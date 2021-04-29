@echo off
echo Asignar dinamicamente
			echo ==================================================================================
			ipconfig
			echo.
			echo ==================================================================================
			echo.
			set /p nombre=INGRESE NOMBRE DEL ADAPTADOR A MODIFICAR:
			netsh interface ip set address "%nombre%" source=dhcp
			netsh interface ip set dns "%nombre%" source=dhcp
			echo.
			echo Proceso terminado
			pause > nul
exit