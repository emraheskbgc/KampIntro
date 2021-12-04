using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.Adi = "Elma";
            Urun1.Aciklama = "Amasya Elması";
            Urun1.Fiyati = 15;

            Product Urun2 = new Product();
            Urun2.Adi = "çilek  ";
            Urun2.Aciklama = "Çilek gibi çilek";
            Urun2.Fiyati = 20;

            //ürün array oluşturcaz : bir veri tipinde ne kadar data eklersek o kadar veri tutan bir dizi.

            Product[] urunler=new Product[] { Urun1, Urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
            }

            Console.WriteLine("----------Methodlar-----------------");

            SepetManager x = new SepetManager();
            x.Ekle(Urun1);
            x.Ekle(Urun2);
       


        }
    }
}
