using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.AdminControllers
{
    public class JobTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
