using Microsoft.AspNetCore.Mvc;

namespace GrowthAPI.GoalRepo
{
    public class ListRepo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
