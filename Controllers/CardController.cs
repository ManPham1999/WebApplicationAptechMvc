using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AptechMVCProject.Controllers
{
    public class CardController : Controller
    {
        // GET
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
            }
            return View();
        }
    }
}