using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class ApplyManager
    {
        //Method injection methodun kullanacagi credi managerin hangisi olacagi yani hangi credi turu olacagi
        //ve hangi Loglayici olacagini enjekte ediyoruz.
        public void ToApply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void LoanPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
