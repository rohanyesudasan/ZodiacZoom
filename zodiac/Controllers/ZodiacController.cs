using Microsoft.AspNetCore.Mvc;

namespace zodiac.Controllers
{
    public class ZodiacController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
