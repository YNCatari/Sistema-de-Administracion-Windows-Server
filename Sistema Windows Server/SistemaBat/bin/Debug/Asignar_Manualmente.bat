@echo off
			set /p nombre=
			set /p ip=
			set /p mas=
			set /p puer=
			set /p dns=
			set /p dns2=
			netsh interface ip set address name="%nombre%" static %ip% %mas% %puer% 
			netsh interface ip set dns name="%nombre%" static %dns% primary
			netsh interface ip set dns name="%nombre%" static %dns2% secondary			
exit