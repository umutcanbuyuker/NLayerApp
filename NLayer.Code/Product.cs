using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Code
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } // [ForeignKey] EFCore standartlarında foreignkey verdik
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    } 
}
