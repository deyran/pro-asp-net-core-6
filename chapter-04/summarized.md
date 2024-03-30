* The .NET SDK includes a set of command-line tools for creating, managing, building, and running project. Using Visual Studio Code, then the command line is the only option.
  
* Listing the .NET Templates -> **dotnet new --list**
  
* Creating a New Project

```
dotnet new globaljson --output MySolution/MyProject
dotnet new web --no-https --output MySolution/MyProject
dotnet new sln -o MySolution
dotnet sln MySolution add MySolution/MyProject
```