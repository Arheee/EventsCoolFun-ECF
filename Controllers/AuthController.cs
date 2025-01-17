using EventsCoolFun_ECF_.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventsCoolFun_ECF_.Controllers
{
    public class AuthController : Controller
    {
        private static readonly List<Admin> Admins = new()
        {
            new Admin { Name = "admin404", Password = "adm" }          
        };

        // GET: AuthController
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                ViewBag.Message = "Veuillez remplir tous les champs.";
                return View();
            }
            var admin = Admins.FirstOrDefault(u => u.Name == name && u.Password == password);

            if (admin != null)
            {
                HttpContext.Session.SetString("name", admin.Name);

                return RedirectToAction("Index", "Home");
               
            }
            ViewBag.Message = "Nom d'utilisateur ou mot de passe incorrect";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
