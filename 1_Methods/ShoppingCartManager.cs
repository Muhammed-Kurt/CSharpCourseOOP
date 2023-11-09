using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Methods
{
    internal class ShoppingCartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Congrats. Shopping Cart Added : " + product.Name);
        }

        public void Add2 (int Id, string Name, double Price, string Description,int UnitStock) //unit_stock ekledik ve Add2 hata verecek
        {
            Console.WriteLine("Congrats. Shopping Cart Added2 : " + Name);
        }
    }
}
