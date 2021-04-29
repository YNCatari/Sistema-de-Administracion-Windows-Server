@echo off
echo Visualizar objetos de un grupo
echo ==============================
echo Objetos de un Grupo Local
echo ==============================
net localgroup
echo.
set /p nom=Ingrese nombre del grupo a visualizar:
net localgroup %nom%
echo.
echo Objetos de un Grupo Global
echo ==============================
net group
echo.
set /p nom2=Ingrese nombre del grupo a visualizar:
net group %nom2%
echo.
exit