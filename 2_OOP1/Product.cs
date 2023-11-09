using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OOP1
{
    internal class Product
    {
        public int Id { get; set; } //Primary Key
        public int CategoryId { get; set; } //Foreign Key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
