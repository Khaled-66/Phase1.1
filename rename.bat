@echo off
mkdir phase1

for /d %%i in (*) do (
    if exist "%%i\%%i.cs" (
        move "%%i\%%i.cs" "phase1\"
        echo Moved "%%i\%%i.cs" to "phase1\"
    )
)

pause
