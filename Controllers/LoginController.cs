using Microsoft.AspNetCore.Mvc;

namespace AptechMVCProject.Controllers
{
    public class LoginController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}