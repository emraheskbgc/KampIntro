using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Engin Demirog
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "1234567890";

            //Kodlama.io
            TuzelMusteri musteri2=  new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45621";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1312312312";

           //Gerçek Müşteri - Tüzel Müşteri

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4= new TuzelMusteri();

            MusteriManager musteriManager= new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
