@echo off
set /p op= 
if %op% == 1 goto op1
if %op% == 2 goto op2
if %oP% == 3 goto main

:op1
set /p nombre=
set /p dominio= 
set /p extension= 
cd C:\PSTools
dsadd computer "CN=%nombre%,CN=Computers,DC=%dominio%,DC=%extension%"
exit

:op2
set /p nombre=
set /p compu=
set /p dominio= 
set /p extension= 
dsadd computer "CN=%nombre%,OU=%compu%,DC=%dominio%,DC=%extension%"
exit

