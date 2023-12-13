using Microsoft.AspNetCore.Mvc;
using zodiac.Migration;
using zodiac.Models;

namespace zodiac.Controllers
{
    public class AccountController : Controller
    {
        private ZodiacContext _db { get; set; }
        public AccountController(ZodiacContext zodiacContext)
        {
            _db = zodiacContext;
        }

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
                if(_db.Users.Any(x => x.Email ==  model.Email))
                {
                    ViewBag.ErrorMessage = "User with same Email already exists";
                    return View(model);
                }
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction("RegistrationSuccess");
            }
            return View(model);
        }

        // GET: /Account/RegistrationSuccess
        public ActionResult RegistrationSuccess()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = _db.Users.SingleOrDefault(x => x.Email == loginVM.Email && x.Password == loginVM.Password);
                if (user != null)
                {
                    HttpContext.Session.SetInt32("UserId", user.Id);
                    HttpContext.Session.SetString("Email", user.Email);
                    HttpContext.Session.SetString("Username", user.Username);
                }
                else
                {
                    ViewBag.ErrorMessage = "Incorrect Email or Password";
                }
            }
            return View();
        }
        public ActionResult index1()
        {
            return View();
        }
    }
}
