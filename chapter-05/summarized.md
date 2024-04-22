# Essencial C# features

# Preparing for this chapter

## Creating a project

**Listing 5-1**. Creating the Example Project

```
dotnet new web --no-https --output LanguageFeatures
dotnet new sln -o LanguageFeatures
dotnet sln LanguageFeatures add LanguageFeatures
```

1. **dotnet new web --no-https --output LanguageFeatures**

* Creates a new ASP.NET Core web application project
* Disables HTTPS for the project
* Sets the output directory to **LanguageFeatures**

2. **dotnet new sln -o LanguageFeatures:**

* Creates a new solution file (**.sln**) in the directory **LanguageFeatures**
* Solution files are used to manage multiple projects as a single unit

3. **dotnet sln LanguageFeatures add LanguageFeatures**

* Adds the **LanguageFeatures project** (.csproj file) to the existing solution file **LanguageFeature.sln**
* Associate the project with the solution, allowing you to build, managem and reference it within the solution

## Enabling the MVC Framework

**Listing 5-2**. Enabling MVC in the Program.cs file in the LanguageFeatures folder

```
var builder = WebApplication.CreateBuilder(args);

// Add services for controllers and views
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.Run();
```

## Creating the application components

### Creating the data model

**Listing 5-3**. The Contents of the Product.cs File in the Models Folder

1. In the terminal

```
dotnet new class -n Product -o Models
``` 

2. The content of the Product class

```
namespace LanguageFeatures;

public class Product
{
    public string Name { get; set; }
    public decimal? Price { get; set; }
    public static Product[] GetProducts()
    {
        Product kayak = new Product
        {
            Name = "Kayak",
            Price = 275M
        };
        Product lifejacket = new Product
        {
            Name = "Lifejacket",
            Price = 48.95M
        };
        return new Product[] { kayak, lifejacket, null };
    }
}
```

### Creating the Controller and View

**Listing 5-4**. The Contents of the *HomeController.cs* File in the *Controllers* Folder

1. Creating the HomeController.cs in the terminal

```
dotnet new mvccontroller -n HomeController -o Controllers
```

2. The Homecontroller.cs content

```
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View(new string[] {"C#", "Language", "Features"});
        }

    }
}
```


## Selecting the HTTP port
## Running the example application