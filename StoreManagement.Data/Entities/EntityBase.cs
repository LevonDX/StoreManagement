using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Data.Entities
{
    public class EntityBase
    {
        [Key]
        public int ID { get; set; }
        public bool Deleted { get; set; }
    }
}
