using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruÜc
    {
        static void Main()
        {
            List<int> sayilar = new List<int>();
            int sayi;

            do
            {
                Console.Write("Sayı giriniz (Çıkmak için 0): ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi > 0)
                    sayilar.Add(sayi);
            } while (sayi != 0);

            List<string> ardışıkGruplar = ArdışıkGruplariBul(sayilar);
            Console.WriteLine("Ardışık gruplar: " + string.Join(", ", ardışıkGruplar));
        }

        static List<string> ArdışıkGruplariBul(List<int> sayilar)
        {
            sayilar.Sort();
            List<string> gruplar = new List<string>();
            int baslangic = sayilar[0];
            int onceki = baslangic;

            for (int i = 1; i < sayilar.Count; i++)
            {
                if (sayilar[i] != onceki + 1)
                {
                    gruplar.Add(baslangic == onceki ? baslangic.ToString() : $"{baslangic}-{onceki}");
                    baslangic = sayilar[i];
                }
                onceki = sayilar[i];
            }

            gruplar.Add(baslangic == onceki ? baslangic.ToString() : $"{baslangic}-{onceki}");
            return gruplar;
        }
    }
}

