using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do not repeat yourself
            //type safety = tip güvenliği 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun =7.45;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu göster");
            }
            else
            {
                Console.WriteLine("eşittir");
;            }


            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine(" Kullanıcı Ayarlar butonu ");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
                
            Console.WriteLine(kategoriEtiketi);

            

        }
    }
}
