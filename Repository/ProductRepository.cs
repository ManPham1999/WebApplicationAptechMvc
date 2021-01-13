using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AptechMVCProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace AptechMVCProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private MainDbContext _db ;

        public ProductRepository(MainDbContext db)
        {
            _db = db;
        }

        public void AddProduct(Product pro)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Guid proId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProductByCatgoryId(string catId)
        {
            IQueryable<Product> chosenPro =  _db.Products.Where(p => p.Catgory.CatId == catId);
            return chosenPro;
        }

        public async Task<Product> GetProductById(Guid proId)
        {
            var chosenPro = await _db.Products.FindAsync(proId);
            return chosenPro;
        }

        public void UpdateProduct(Guid proId)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Product>> IProductRepository.GetAllProducts()
        {
            return await _db.Products.ToListAsync();
        }
        
    }
}