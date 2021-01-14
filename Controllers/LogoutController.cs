using Microsoft.AspNetCore.Mvc;

namespace AptechMVCProject.Controllers
{
    public class LogoutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}