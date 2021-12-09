using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
     class BasvuruManager
    {
        public void BasvuruYap( IKrediManager krediManager, ILoggerServices loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
           
           krediManager.Hesapla();
            loggerServices.Log();
        }

        public void KrediOnBilgilendiremesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager ihtiyacKrediManager, List<ILoggerServices> loggerServices)
        {
            
            
        }
    }
}
