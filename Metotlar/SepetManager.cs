using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {
        //naming convention
        //normal parantez olan biyerde method çalışır.
        //syntax - yazım şekli.
        public void Ekle( Product   urun)//parantez içindeki kısım bizim parametremiz.
        {
            Console.WriteLine("sepete eklendi" + urun.Adi);
        }
    }
}
