# PSNoWindow

- clone repo

- cd PSNoWindow

- dotnet publish -c Release -r win10-x64

- cd \bin\Release\netcoreapp2.1\win10-x64

- .\PSNoWindow.exe

There's a few lines commented out in Program.cs which print the results from the Powershell executed and the last which holds the console window open until you press a key.

This started from a discussion on https://reddit.com/r/powershell about running PS with no visible PS window. This also demonstrates the futility of attempted security measures like blocking powershell.exe to prevent malicious use. Powershell can still be invoked.
