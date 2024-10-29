using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruBes
    {
        static void Main()
        {
            Console.WriteLine("Polinomları girin (örnek: 2x^2 + 3x - 5):");
            Console.Write("Birinci polinom: ");
            string polinom1 = Console.ReadLine();
            Console.Write("İkinci polinom: ");
            string polinom2 = Console.ReadLine();

            var p1 = PolinomOku(polinom1);
            var p2 = PolinomOku(polinom2);

            Console.WriteLine("Toplama sonucu: " + PolinomToString(PolinomTopla(p1, p2)));
            Console.WriteLine("Çıkarma sonucu: " + PolinomToString(PolinomTopla(p1, PolinomTers(p2))));
        }

        static Dictionary<int, int> PolinomOku(string polinom)
        {
            var terimler = new Dictionary<int, int>();
            string[] parcalar = polinom.Split(new[] { ' ', '+' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string parca in parcalar)
            {
                int katsayi, derece = 0;
                string[] ayrik = parca.Split('x');
                katsayi = ayrik[0] == "" ? 1 : int.Parse(ayrik[0]);
                if (ayrik.Length > 1)
                    derece = ayrik[1] == "^2" ? 2 : 1;

                if (terimler.ContainsKey(derece))
                    terimler[derece] += katsayi;
                else
                    terimler[derece] = katsayi;
            }

            return terimler;
        }

        static Dictionary<int, int> PolinomTopla(Dictionary<int, int> p1, Dictionary<int, int> p2)
        {
            var sonuc = new Dictionary<int, int>(p1);
            foreach (var terim in p2)
            {
                if (sonuc.ContainsKey(terim.Key))
                    sonuc[terim.Key] += terim.Value;
                else
                    sonuc[terim.Key] = terim.Value;
            }
            return sonuc;
        }

        static Dictionary<int, int> PolinomTers(Dictionary<int, int> p)
        {
            var sonuc = new Dictionary<int, int>();
            foreach (var terim in p)
                sonuc[terim.Key] = -terim.Value;

            return sonuc;
        }

        static string PolinomToString(Dictionary<int, int> p)
        {
            List<string> terimler = new List<string>();
            foreach (var terim in p)
            {
                string ifade = terim.Value > 0 ? $"+{terim.Value}" : $"{terim.Value}";
                terimler.Add($"{ifade}x^{terim.Key}");
            }
            return string.Join(" ", terimler);
        }
    }
}

