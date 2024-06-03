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

            //! string interpolation allows insert value of the variable into the string
            //Sytanxe $"{variable}"

            return View(
                new string[]
                {
                    $"Name: {products[0]?.Name}, Price: {products[0]?.Price:C2}"
                }
            );
        }

    }
}
