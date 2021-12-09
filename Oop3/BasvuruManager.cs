using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
     class BasvuruManager
    {
        public void BasvuruYap( IKrediManager krediManager, List<ILoggerServices> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
           
           krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendiremesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        
    }
}
