**Global using statements** simplify code by reducing redundancy and avoiding namespace clashes. They allow you to declare common namespaces once at the top of file, improving readability and consistency

Too see how this works in practice, follow the next steps:

1. Create file called GlobalUsings.cs in the LanguageFeatures project
2. Add the content below to the GlobalUsings.cs file

```
global using LanguageFeatures;
global using Microsoft.AspNetCore.Mvc;
```

3. Open the HomeController.cs file and comment out the **using** statements as shown in the code below:

```
//using LanguageFeatures;
//using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ViewResult Index()
        {
            Product?[] products = Product.GetProducts();
            
            return View(new string[] { products[0]?.Name });
        }

    }
}
```