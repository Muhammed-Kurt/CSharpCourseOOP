using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP3
{
    internal class ApplicationManager //Başvuru Yönetici
    {
        //Method Injection
        public void MakeApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)//Dependency Injection
        {
            //Başvuran bilgilerini değerlendirme

            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void ProvideCreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
