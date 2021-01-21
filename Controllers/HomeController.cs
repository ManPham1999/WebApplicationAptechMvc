using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AptechMVCProject.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AptechMVCProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace AptechMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MainDbContext _context ;

        public HomeController(ILogger<HomeController> logger,MainDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> LoginAction([Bind("Email,Password")]
            User user)
        {
            if (ModelState.IsValid)
            {
                var check = await _context.Users.FirstOrDefaultAsync(user1 => user1.Email == user.Email );
                if (check != null)
                {
                    HttpContext.Session.SetString("UserName",check.Email);
                    RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
