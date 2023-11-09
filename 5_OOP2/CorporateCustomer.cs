using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP2
{
    //Miras = Inheritance
    internal class CorporateCustomer : Customer // : Customer => Inheritance //Child Class
    {
        //Coorporate = Tüzel (Şirket)
        public string CompanyName { get; set; } //Şirket Adı
        public string TaxNumber { get; set; } // Vergi Numarası
    }
}
