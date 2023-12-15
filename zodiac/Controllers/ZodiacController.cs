using Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace zodiac.Controllers
{
    public class ZodiacController : Controller
    {
        private ZodiacContext _DbContext { get; set; }
        public ZodiacController(ZodiacContext zodiacContext)
        {
            _DbContext = zodiacContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ZodiacVM zodiacVM)
        {
            var yearDiff = zodiacVM.BirthDate.Year - 1970;
            zodiacVM.ZodiacSign = _DbContext.Zodiacs
            .Single(x => zodiacVM.BirthDate >= x.FromDate.AddYears(yearDiff)
                && zodiacVM.BirthDate <= x.ToDate.AddYears(yearDiff))
            .ZodiacSign;


            return View(zodiacVM);
        }
    }
}
