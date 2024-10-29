using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruİki
    {
        static void Main()
        {
            List<int> sayilar = new List<int>();
            int sayi;

            do
            {
                Console.Write("Pozitif tam sayı giriniz (Çıkmak için 0): ");
                sayi = int.Parse(Console.ReadLine());

                if (sayi > 0)
                    sayilar.Add(sayi);
            } while (sayi != 0);

            if (sayilar.Count > 0)
            {
                double ortalama = sayilar.Average();
                double medyan = HesaplaMedyan(sayilar);

                Console.WriteLine($"Ortalama: {ortalama}");
                Console.WriteLine($"Medyan: {medyan}");
            }
            else
            {
                Console.WriteLine("Geçerli sayı girilmedi.");
            }
        }

        static double HesaplaMedyan(List<int> sayilar)
        {
            sayilar.Sort();
            int ortadakiIndex = sayilar.Count / 2;
            return sayilar.Count % 2 == 0 ? (sayilar[ortadakiIndex - 1] + sayilar[ortadakiIndex]) / 2.0 : sayilar[ortadakiIndex];
        }
    }

}

