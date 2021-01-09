using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using AptechMVCProject.Entity;
using AptechMVCProject.Models;
using AptechMVCProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AptechMVCProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly MainDbContext _context ;
        private ProductRepository _productRepository;
        public ProductController(MainDbContext context)
        {
            _context = context;
            _productRepository = new ProductRepository(_context);
        }

        public async Task<IActionResult> Index(string id)
        {
            if (id != "")
            {
                ModelView mymodel = new ModelView();
                mymodel.products = _productRepository.GetProductByCatgoryId(id);
                mymodel.catgories = await _context.Catgories.ToListAsync();
                mymodel.routeParamsString = id;
                return View(mymodel);
            }
            return Error();
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(Guid id)
        {
            ModelView mymodel = new ModelView();
            mymodel.product = _productRepository.GetProductById(id);
            mymodel.routeParamsUnique = id;
            return View(mymodel);
        }
    }
}