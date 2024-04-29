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
            
            return View(new string[] { products[0]!.Name });
        }

    }
}
