using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestingMVC.Models
{
    public class ProductSource : IDataSource
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Name="Bat",Price=4500},
                new Product(){Name="Ball",Price=500}
            };
        }
    }
}
