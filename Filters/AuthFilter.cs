using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EventsCoolFun_ECF_.Filters
{
    public class AuthFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Vérifie si l'utilisateur est authentifié
            var isAuthenticated = context.HttpContext.Session.GetString("Name") != null;

            if (!isAuthenticated)
            {
                // Redirige vers la page de connexion si non authentifié
                context.Result = new RedirectToActionResult("Login", "Auth", null);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Action après l'exécution 
        }
    }
}
