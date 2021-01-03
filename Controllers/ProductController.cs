using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AptechMVCProject.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AptechMVCProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly MainDbContext _context;
        public ProductController(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string id)
        {
            ModelView mymodel = new ModelView();
            var chosenCate = await _context.Catgories.FirstOrDefaultAsync(item => item.CatId == id);
            var chosenPro = await _context.Products.FindAsync(chosenCate.CoffeeRefId);
            mymodel.product = chosenPro;
            mymodel.catgories = await _context.Catgories.ToListAsync();
            mymodel.routeParams = id;
            return View(mymodel);
        }
        public async Task<IActionResult> Details(string id)
        {
            var ahjhj = await _context.Catgories.FirstOrDefaultAsync(item => item.CatId == id);
            var pro = await _context.Products.FindAsync(ahjhj.CoffeeRefId);
            return View(pro);
        }
    }
}