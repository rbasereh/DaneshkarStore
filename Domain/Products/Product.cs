using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //todo:Move to ProductStore
        public int Count { get; set; }
        public ProductStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
