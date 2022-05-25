using Microsoft.AspNetCore.Mvc;

namespace GrowthAPI.Controllers
{
    public class UserLoginAPI : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
