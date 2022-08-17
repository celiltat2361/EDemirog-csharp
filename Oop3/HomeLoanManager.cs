using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class HomeLoanManager : ICreditManager
    {
        public void Add()
        {
            Console.WriteLine("Added Personal Credit...");
        }

        public void Calculate()
        {
            Console.WriteLine("Calculated Home Credit...");
        }
    }
}
