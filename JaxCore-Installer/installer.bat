@echo off
cd %1%

powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/Siticone.UI.dll -O Siticone.UI.dll
powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/JaxCore.exe -O JaxCore.exe