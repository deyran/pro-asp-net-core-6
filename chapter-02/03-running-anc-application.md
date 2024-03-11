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

The code below (Listing 2-6) shows us a simple example of a controller class:

**Listing 2-6**. Changing the HomeController.cs File in the Controllers Folder

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

### Understanding Routes

The **ASP.NET Core routing system** handle incoming HTTP requests by matching them to specific controller actions. The routing system uses rules defined in the **route** to determine how a request should be processed.

When the ASP.Net Core project is created, a **default rule** is automatically configured. The route below show us an example of default rule:

```
/
/Home
/Home/Index
```

Appending */Home* or */Home/Index* to the URL will display the same **Hello World** result from the application

### Understanding HTML Rendering

#### Creating and Rendering a View

Change the *Index.cshtml* file, seen in the **Listing 2-6** to match the **Listing 2-7**

**Listing 2-7**. Rendering a View in the HomeController.cs File in the Controllers Folder

```
using Microsoft.AspNetCore.Mvc;
namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
    }
}
```

When an action method in ASP.NET returns a ViewResult object, it makes the framework render a view. Developers call the view method and specify the name of the view they want to use (e.g. "MyView"). If you try to run the project, it will fail because the view called "MyView" has not yet been created.

Views in ASP.NET Core are stored in the **Views** folder. They are organized into subfolders based on controllers. For instance, views associated with the **HomeController** are stored in folder callde **Views/Home**
<!--
# Chapter 2: Getting Started
## Running the ASP.NET Core Application
### Putting the pieces together
#### Creating and Rendering a View
-->


#### Adding dynamic output

### Putting the pieces together