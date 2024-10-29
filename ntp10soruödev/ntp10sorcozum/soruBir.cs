using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruBir
    {
        static void Main()
        {
            // Kullanıcıdan bir dizi alın
            Console.WriteLine("Dizi uzunluğunu giriniz:");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Sayı {i + 1}: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            // Diziyi sıralama
            Array.Sort(dizi);
            Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", dizi));

            // İkili arama ile sayı kontrolü
            Console.Write("Aramak istediğiniz sayıyı giriniz: ");
            int arananSayi = int.Parse(Console.ReadLine());
            int sonuc = Array.BinarySearch(dizi, arananSayi);

            if (sonuc >= 0)
                Console.WriteLine("Sayı dizide mevcut.");
            else
                Console.WriteLine("Sayı dizide mevcut değil.");
        }
    }

}

