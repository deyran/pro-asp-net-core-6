# [Intro to VSCode for C# Developers - From Installation to Debugging](https://youtu.be/r5dtl9Uq9V0?si=5jSZj9L_z0vJyHD2)

## Create the Solution

```
dotnet new sln -n "VSCodeIntroSln"
dotnet new console -n "IntroUI"
dotnet new classlib -n "IntroLibrary"
dotnet sln VSCodeIntroSln.sln add ./IntroUI/IntroUI.csproj
dotnet add IntroUI/IntroUI.csproj reference IntroLibrary/IntroLibrary.csproj
```