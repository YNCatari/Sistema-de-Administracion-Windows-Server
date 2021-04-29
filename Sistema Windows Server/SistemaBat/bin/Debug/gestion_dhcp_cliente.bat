@echo off
title Gestion DHCP cliente
:main
cls
set /p op=
if %op% == 1 ipconfig /release
if %op% == 2 ipconfig /renew
exit
