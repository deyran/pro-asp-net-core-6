# Chapter 2: Getting Started

## Running the ASP.NET Core Application

When the project is created, a file named **launchSettings.json** is created in the **Properties** folder, and it is this file that determinates which HTTP port ASP.NET Core will use to listen for HTTP requests. The content of the launchSettings.json file can be shown in the code bellow:

```
{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:5000",
      "sslPort": 0
    }
  },
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```

### Understanding Endpoints

In an ASP.NET Core applications, incoming requests are handled by **endpoints** also known **actions**. Each action is defined in a class called controller that is derived from the *Microsoft.AspNetCore.Mvc.Controller* class. The controller class allows you to handle HTTP requests by invoking specific **actions methods**.

Controller classes follow a naming convention where the class name is followed by the word "Controller". For example, HomeController.cs, the controller name is Home.

The code below shows us a simple example of a controller class:

```
using Microsoft.AspNetCore.Mvc;
namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
    }
}
```

### Understanding Routes 27
### Understanding HTML Rendering
### Putting the pieces together