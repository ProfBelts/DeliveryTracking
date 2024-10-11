using Microsoft.AspNetCore.Mvc;

namespace DeliveryTracking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return View();
        }

    }
    
}
