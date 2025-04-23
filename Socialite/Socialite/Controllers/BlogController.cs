using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
