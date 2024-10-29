using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.AdminControllers
{
    public class JobSkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
