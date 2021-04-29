@echo off
netsh interface ipv4 show addres %nombre%
netsh interface ipv4 show dns %nombre%
exit