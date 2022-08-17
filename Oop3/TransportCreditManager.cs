using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
  class TransportCreditManager : ICreditManager
    {
        public void Add()
        {
            Console.WriteLine("Added Transport Credit...");
        }

        public void Calculate()
        {
            Console.WriteLine("Calculated Transport Credit...");
        }
    }
}
