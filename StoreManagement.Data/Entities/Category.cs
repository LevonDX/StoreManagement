using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Data.Entities
{
    public  class Category : EntityBase
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public virtual List<Product> Products { get; set; }
    }
}
