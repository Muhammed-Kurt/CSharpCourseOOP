namespace _1_2_ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value And Reference Types - Değer ve Referans Tipler
            //int, decimal, float, double, bool = Value Type - Değer Tip
            //Array, Class, interface = Reference Type - Referans Tip

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //number1 ?? => 30

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0] ?? => 999

            #endregion

        }
    }
}