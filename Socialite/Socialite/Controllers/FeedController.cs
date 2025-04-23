using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class FeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
