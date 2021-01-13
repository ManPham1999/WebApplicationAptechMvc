using System;
using System.Collections.Generic;

namespace AptechMVCProject.Entity
{
    public class CartDetails
    {
        public Guid Id { get; set; }
        public string CartRefId { get; set; }
        public Cart Cart { get; set; }
        public List<ProductListInCart> ProductListInCarts { get; set; }
    }
}