using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP3
{
    internal class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit payment plan calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
