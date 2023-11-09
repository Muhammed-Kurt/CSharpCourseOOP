namespace _3_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collections - Koleksiyonlar
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "İlker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);
            #region Lists
            List<string> names2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker"); //Ekleme işlemi için Add metodunu çağırdık.
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            #endregion
            #endregion
        }
    }
}