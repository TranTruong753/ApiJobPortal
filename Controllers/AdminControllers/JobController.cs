using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.AdminControllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
