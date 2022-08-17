using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class PersonalCreditManager : ICreditManager
    {
        public void Add()
        {
            Console.WriteLine("Added Personal Credit...");
        }

        public void Calculate()
        {
            Console.WriteLine("Calculated Personal Credit...");
        }
    }
}
