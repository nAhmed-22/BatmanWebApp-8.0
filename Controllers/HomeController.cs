using Microsoft.AspNetCore.Mvc;

namespace BatmanWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}