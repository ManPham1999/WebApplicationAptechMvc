using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AptechMVCProject.Controllers
{
    //[Route("api/[controller]")]
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AboutController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
            }
            return View();
        }
    }
}
