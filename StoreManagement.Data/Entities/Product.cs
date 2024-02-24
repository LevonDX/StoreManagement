using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Data.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; } = "";

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? UnitPrice { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; } = "";

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; } // navigation property
    }
}
