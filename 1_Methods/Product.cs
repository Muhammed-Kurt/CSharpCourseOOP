using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Methods
{
    internal class Product
    {
        //Aşağıdakilerin her biri bir property'dir - Property = Özellik
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int UnitStock { get; set; }

    }
}
