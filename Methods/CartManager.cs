using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"Added in cart.. {product.Name}");
        }
        public void Delete(Product product)
        {
            Console.WriteLine($"Product deleted... {product.Name}");
        }
    }
}
