using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.AdminControllers
{
    public class JobSeekerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
