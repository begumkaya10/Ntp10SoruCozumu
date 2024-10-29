using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruOn
    {
        static void Main()
        {
            int[] sayilar = { 1, 2, 3, 4 };
            string[] operatorler = { "+", "-", "*", "/" };

            KapıyıAc(sayilar, operatorler);
        }

        static void KapıyıAc(int[] sayilar, string[] operatorler)
        {
            foreach (var op1 in operatorler)
            {
                foreach (var op2 in operatorler)
                {
                    foreach (var op3 in operatorler)
                    {
                        string ifade = $"{sayilar[0]} {op1} {sayilar[1]} {op2} {sayilar[2]} {op3} {sayilar[3]}";
                        if (Hesapla(ifade) > 0)
                        {
                            Console.WriteLine("Geçerli ifade: " + ifade);
                        }
                    }
                }
            }
        }

        static double Hesapla(string ifade)
        {
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(ifade, ""));
        }
    }
}

