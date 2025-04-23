using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
