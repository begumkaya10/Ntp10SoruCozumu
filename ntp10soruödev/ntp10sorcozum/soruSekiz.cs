using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruSekiz
    {
        static void Main()
        {
            Console.Write("Şifrelenmiş mesajı girin: ");
            string sifreliMesaj = Console.ReadLine();
            string cozulmusMesaj = SifreCoz(sifreliMesaj);
            Console.WriteLine("Çözülmüş mesaj: " + cozulmusMesaj);
        }

        static string SifreCoz(string sifreliMesaj)
        {
            List<int> fibonacci = FibonacciDizisiOlustur(sifreliMesaj.Length);
            char[] cozulmus = new char[sifreliMesaj.Length];

            for (int i = 0; i < sifreliMesaj.Length; i++)
            {
                int asciiDeger = (int)sifreliMesaj[i];
                int modDegeri = AsalMi(i + 1) ? 100 : 256;
                int orjinalAscii = asciiDeger * fibonacci[i] % modDegeri;
                cozulmus[i] = (char)orjinalAscii;
            }

            return new string(cozulmus);
        }

        static List<int> FibonacciDizisiOlustur(int uzunluk)
        {
            List<int> fibonacci = new List<int> { 1, 1 };
            for (int i = 2; i < uzunluk; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }
            return fibonacci;
        }

        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }
    }
}

