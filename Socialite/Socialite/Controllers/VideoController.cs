using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
