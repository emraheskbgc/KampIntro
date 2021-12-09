using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
     class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();            
            IKrediManager tasitKrediManager = new TasitKrediManager();          
            IKrediManager konutKrediManager= new KonutKrediManager();

            ILoggerServices databaseLoggerService = new DatabaseLoggerService();
            ILoggerServices fileLogerservice = new FileLoggerService();
            ILoggerServices smsLogerService = new SmsLoggerService();

            BasvuruManager basvuruManager=new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager, smsLogerService) ;

            

          
            List<IKrediManager> krediler = new List<IKrediManager>
            {
                ihtiyacKrediManager,tasitKrediManager,konutKrediManager
            };

            //basvuruManager.KrediOnBilgilendiremesiYap(krediler);

        }
    }
}
