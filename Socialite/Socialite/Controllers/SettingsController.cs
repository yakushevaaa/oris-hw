using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
