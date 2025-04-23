using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class GroupsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
