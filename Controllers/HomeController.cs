using System.Diagnostics;
using EventsCoolFun_ECF_.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventsCoolFun_ECF_.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            // Vérifier si l'utilisateur est connecté
            var name = HttpContext.Session.GetString("Name");

            if (string.IsNullOrEmpty(name))
            {
                // Si l'utilisateur n'est pas connecté, rediriger vers la page de connexion
                return RedirectToAction("Login", "Auth");
            }

        
            ViewBag.Name = name; 
            return View();
        }
    }
}
