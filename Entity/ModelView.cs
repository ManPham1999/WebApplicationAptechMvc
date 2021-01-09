using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AptechMVCProject.Entity
{
    public class ModelView
    {
        public IEnumerable<Catgory> catgories { get; set; }
        public IQueryable<Product> products { get; set; }
        public Task<Product> product { get; set;  }
        public string routeParamsString { get; set; }
        public Guid routeParamsUnique { get; set; }
    }
}
