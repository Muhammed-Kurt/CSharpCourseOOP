using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP2
{
    internal class IndividualCustomer : Customer //Child Class
    {
        //Individual = Gerçek (Birey)
        public string IdentityNumber { get; set; } //Kimlik Numarası
        public string Name { get; set; }
        public string Surname { get; set; }
        
    }
}
