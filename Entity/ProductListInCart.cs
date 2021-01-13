using System;

namespace AptechMVCProject.Entity
{
    public class ProductListInCart
    {
        public Guid Id { get; set; }
        public string ProductRefId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}