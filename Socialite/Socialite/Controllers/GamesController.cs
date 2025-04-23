using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
