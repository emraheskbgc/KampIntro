using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurss1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurss2 = "Programlamaya başlangıç için temel kurs";
            string kurss3 = "java";

            //array - diziler

            string[] kurslar = new string[]{ "Yazılım Geliştirici Yetiştirme Kampı",
                                            "Programlamaya başlangıç için temel kurs", "java","python" };

            for (int i = 0 ; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
