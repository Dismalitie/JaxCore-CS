@echo off
echo JaxCore-CS Installer v1.6
echo Installing to %CD%...
echo.

echo [installer]:[cs-core]:[dependencies] Installing core dependencies...
powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/Siticone.UI.dll -O Siticone.UI.dll && echo [installer]:[cs-core]:[dependencies] Dependencies installed.

echo [installer]:[cs-core]:[exe] Installing core executable...
powershell.exe curl https://github.com/Dismalitie/JaxCore-CS/raw/main/JaxCore/bin/Debug/JaxCore.exe -O JaxCore.exe && echo [installer]:[cs-core]:[exe] Executable installed.

echo [installer]:[extra] Installing extra resource files...
powershell.exe https://raw.githubusercontent.com/Dismalitie/JaxCore-CS/main/JaxCore/.unistall.bat

echo [installer] Installation complete, starting JaxCore.
echo You can now close this window.
start JaxCore.exe