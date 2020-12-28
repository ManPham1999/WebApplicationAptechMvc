using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AptechMVCProject.Entity
{
    public class Catgory
    {
        public Catgory()
        {
        }
        [Key]
        public string CatId { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Product")]
        public Guid CoffeeRefId { get; set; }
        public Product Coffee { get; set; }
    }
}
