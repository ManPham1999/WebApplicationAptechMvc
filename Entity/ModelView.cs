using System;
using System.Collections.Generic;

namespace AptechMVCProject.Entity
{
    public class ModelView
    {
        public IEnumerable<Catgory> catgories { get; set; }
        public IEnumerable<Product> products { get; set; }
        public Product product { get; set; }
        public string routeParams { get; set; }
    }
}
