cls
@echo off
title Locker
color 03
if EXIST "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" goto UNLOCK
if NOT EXIST Locker goto MDLOCKER

:CONFIRM
echo Are you sure you want to lock the folder? (Y/N)
set/p "lock=>"
if %lock%==Y goto LOCK
if %lock%==y goto LOCK
if %lock%==n goto END
if %lock%==N goto END
cls
echo Invalid choice.
goto CONFIRM

:LOCK
ren Locker "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
attrib +h +s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
echo Folder locked!
ping 127.0.0.1 -n 2 > nul
goto End

:UNLOCK
echo Enter password to unlock folder...
set/p truepass=<"Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}/pass.txt"
set/p "pass=>"
if NOT %pass%==%truepass% goto FAIL
attrib -h -s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
ren "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" Locker
echo Folder unlocked!
ping 127.0.0.1 -n 2 > nul
goto End

:FAIL
color 40
echo INVALID PASSWORD
ping 127.0.0.1 -n 2 > nul
goto End

:MDLOCKER
md Locker
echo Welcome to Locker!
echo.
echo Version 1 (02/15/18)
echo By Owen Goodwin
echo.
echo Created locker directory!
echo Create a password...
set/p "makepass=>"
echo %makepass%>"Locker/pass.txt"
ping 127.0.0.1 -n 2 > nul
echo Success! You can change your password any time by changing the pass.txt file inside the Locker!
ping 127.0.0.1 -n 4 > nul
goto End

:End