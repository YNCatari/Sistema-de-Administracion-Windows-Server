@echo off
set /p d=
set /p dir=
set /p nom=
set /p pc= 
if %pc% == si goto resp1
if %pc% == no goto resp3

:resp3

set /p p=
if %p% == 1 goto sle
if %p% == 2 goto le
if %p% == 3 goto na

:resp1
set /p n=
set /p pc1=
set /p p=
if %p% == 1 goto sle2
if %p% == 2 goto le2
if %p% == 3 goto na2

:sle2
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom%=%d%:\%dir% -o ro=%pc1%
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom% -o na
exit

:le2
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom%=%d%:\%dir% -o rw=%pc1%
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom% -o na
exit

:na2
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom%=%d%:\%dir% -o na=%pc1%
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom% -o na
exit


:resp2
if %p% == 1 goto sle
if %p% == 2 goto le
if %p% == 3 goto na

:sle
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom%=%d%:\%dir% -o ro
exit

:le
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom%=%d%:\%dir% -o rw
exit

:na
cd C:\PSTools
psexec \\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare %nom%=%d%:\%dir% -o na
exit