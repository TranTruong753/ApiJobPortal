using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.AdminControllers
{
    public class JobLevelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
