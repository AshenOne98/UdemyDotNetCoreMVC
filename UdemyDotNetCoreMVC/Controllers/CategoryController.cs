using Microsoft.AspNetCore.Mvc;

namespace UdemyDotNetCoreMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
