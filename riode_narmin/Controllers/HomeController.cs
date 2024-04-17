using Microsoft.AspNetCore.Mvc;

namespace riode_narmin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
