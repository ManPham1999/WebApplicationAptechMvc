using System;
using System.Collections.Generic;

namespace AptechMVCProject.Entity
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserRefId { get; set; }
        public string CardDetail { get; set; }
        public User User { get; set; }
        public string CardTypeRefId { get; set; }
        public CartType CardType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<CartDetails> CartDetailses { get; set; }
        public double TotalMoney { get; set; }
    }
}