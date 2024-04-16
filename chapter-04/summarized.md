* The .NET SDK includes a set of command-line tools for creating, managing, building, and running project. Using Visual Studio Code, then the command line is the only option.
  
* Listing the .NET Templates -> **dotnet new --list**
  
* Creating a New Project

```
dotnet new globaljson --output MySolution/MyProject
dotnet new web --no-https --output MySolution/MyProject
dotnet new sln -o MySolution
dotnet sln MySolution add MySolution/MyProject
```

* To open the project in Visual Studio Code, follow these steps:

1. Start Visual Studio Code.
2. Select **File > Open Folder**
3. Navigate to the **MySolution** folder

## Adding Code and Content to Projects

1. In **MyProject** create a folder called **wwwroot**
2. Inside the **wwwroot** folder create new file called **demo.html**
   
## Understanding Item Scaffolding

1. **Item Templates in Visual**  

   1. Templates are useful for creating file
   2. They simplify the process of creating new files

2. **Scaffolded items** refer to pre-generated code templates that help you quickly create common components of your application. These templates provide a starting point for various features, such as controllers, views, and data access.

## Building and running projects

1. In the MyProject folder, open the **Program.cs** class file and type to match to the code below:

```
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.Run();
```

* The purpose of the statement **app.UseStaticFiles();** is to enabling static content support for handling HTTP requests with static content located in the wwwroot folder

2. Next step is to **configure the HTTP port** that ASP.NET Core will use to handle incoming requests. This can be done by editing the **launchSettings.json** file
   
3. To **build** the example project, open the terminal and run the following command: **dotnet build**

4. Now run the project using the following command: **dotnet run**