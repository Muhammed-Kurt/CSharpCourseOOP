using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP3
{
    internal class TradesmanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tradesman credit payment plan calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
