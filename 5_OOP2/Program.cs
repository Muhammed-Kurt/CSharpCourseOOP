namespace _5_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNumber = "12345";
            individualCustomer1.Name = "Engin";
            individualCustomer1.Surname = "Demiroğ";
            individualCustomer1.IdentityNumber = "12345678901";

            //Kodlama.io
            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 1;
            corporateCustomer1.CustomerNumber = "54321";
            corporateCustomer1.CompanyName = "Kodlama.io";
            corporateCustomer1.TaxNumber = "1234567890";

            //Corporate Customer - Individual Customer
            //SOLID
            //Customer base class olduğu için hem individual customer'ı referans olarak tutabilir
            //Hemde corporate customer'ı referans olarak tutabilir.
            Customer customer1 = new IndividualCustomer();  
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.Add(customer2);
            customerManager1.Add(individualCustomer1);
            customerManager1.Add(corporateCustomer1);
        }
    }
}