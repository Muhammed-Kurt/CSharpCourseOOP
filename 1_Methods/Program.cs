namespace _1_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods - Metotlar
            //Dont repeat yourself - DRY - Clean Code - Best Practice
            //Metot: Bir işlem birden fazla yerde kullanılıyorsa bunu metot olarak yazıp daha kolay ve kod karmaşası olmadan kullanabiliriz.

            /*Best Practice
             * Naming Convention - İsimlendirme Kuralı (camelCase , PascalCase vb.)
            */

            #region Metotlara Class Ekleme

            Product product1 = new Product(); //Product sınıfında bir nesne oluşturduk.
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya Apple";
            product1.UnitStock = 10;
            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakır Watermelon";
            product2.UnitStock = 20;

            Product[] products = new Product[] { product1, product2 };
            //Product sınıfında bir array oluşturduk ve productları ekledik
            //Diziler çoğul isimlendirilir.

            //type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine("Id: {0} \nName: {1} \nPrice: {2} \nDescription: {3}\n ", product.Id, product.Name, product.Price, product.Description);
                Console.WriteLine("-------------------------------");
            }


            Console.WriteLine("---------------METHODS----------------");

            //instance - örnek
            //Doğru kullanım
            //Encapsulation: Ayrı ayrı yazılacak ve düzensiz olacak yapıyı düzene sokarak çalışmak.
            ShoppingCartManager shoppingCartManager = new ShoppingCartManager();
            shoppingCartManager.Add(product1); //Add Method
            shoppingCartManager.Add(product2);

            Console.WriteLine("------------------------------------------");
            //Yanlış Kullanım
            shoppingCartManager.Add2(1, "Pear", 12, "Green Pear", 10); //Add2 Method
            shoppingCartManager.Add2(2, "Apple", 15, "Amasya Apple", 10);
            shoppingCartManager.Add2(3, "Watermelon", 80, "Diyarbakır Watermelon", 20);
            #endregion
            #endregion

        }
    }
}