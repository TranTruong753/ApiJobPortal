using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers.AdminControllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
