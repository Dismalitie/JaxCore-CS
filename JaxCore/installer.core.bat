@echo off
echo JaxCore-CS Installer v1.2
echo Installing to %CD%...
echo.

echo [installer]:[cs-core]:[dependencies] Installing core dependencies...
powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/Siticone.UI.dll -O Siticone.UI.dll && echo [installer]:[cs-core]:[dependencies] Dependencies installed.

echo [installer]:[cs-core]:[exe] Installing core executable...
powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/JaxCore.exe -O JaxCore.exe && echo [installer]:[cs-core]:[exe] Executable installed.

echo [installer] Installation complete, starting JaxCore.
start JaxCore.exe