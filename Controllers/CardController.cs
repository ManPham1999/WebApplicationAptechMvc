using Microsoft.AspNetCore.Mvc;

namespace AptechMVCProject.Controllers
{
    public class CardController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}