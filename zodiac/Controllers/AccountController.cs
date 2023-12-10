using Microsoft.AspNetCore.Mvc;
using zodiac.Models;

namespace zodiac.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public ActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Perform user registration logic here
                // For simplicity, let's just redirect to a success page
                return RedirectToAction("RegistrationSuccess");
            }

            // If the model is not valid, return to the registration page with error messages
            return View(model);
        }

        // GET: /Account/RegistrationSuccess
        public ActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
