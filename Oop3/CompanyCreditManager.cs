using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    internal class CompanyCreditManager : ICreditManager
    {
        public void Add()
        {
            Console.WriteLine("Added Company Credit...");
        }

        public void Calculate()
        {
            Console.WriteLine("Calculated Comapany Credit...");
        }
    }
}
