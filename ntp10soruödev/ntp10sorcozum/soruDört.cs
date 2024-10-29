using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruDört
    {
        static void Main()
        {
            Console.Write("Matematiksel ifadeyi giriniz: ");
            string ifade = Console.ReadLine();

            try
            {
                Console.WriteLine("İşlem adımları:");
                double sonuc = IslemOnceligi(ifade);
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        static double IslemOnceligi(string ifade)
        {
            DataTable dt = new DataTable();
            var sonuc = dt.Compute(ifade, "");
            return Convert.ToDouble(sonuc);
        }
    }
}

