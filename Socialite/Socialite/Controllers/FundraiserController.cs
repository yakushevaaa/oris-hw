using Microsoft.AspNetCore.Mvc;

namespace Socialite.Controllers
{
    public class FundraiserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
