using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
