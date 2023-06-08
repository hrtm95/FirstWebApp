using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
