using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruAltı
    {
        static void Main()
        {
            Console.WriteLine("Cihazın kabul ettiği geçerli tarihler:");

            for (int yil = 2000; yil <= 3000; yil++)
            {
                if (YilKontrol(yil))
                {
                    for (int ay = 1; ay <= 12; ay++)
                    {
                        if (AyKontrol(ay))
                        {
                            for (int gun = 1; gun <= 31; gun++)
                            {
                                if (GunKontrol(gun))
                                {
                                    Console.WriteLine($"{gun}/{ay}/{yil}");
                                }
                            }
                        }
                    }
                }
            }
        }

        static bool YilKontrol(int yil)
        {
            int toplam = 0;
            int yilDegeri = yil;
            while (yilDegeri > 0)
            {
                toplam += yilDegeri % 10;
                yilDegeri /= 10;
            }
            return toplam < (yil / 4);
        }

        static bool AyKontrol(int ay)
        {
            int toplam = 0;
            while (ay > 0)
            {
                toplam += ay % 10;
                ay /= 10;
            }
            return toplam % 2 == 0;
        }

        static bool GunKontrol(int gun)
        {
            if (gun < 2) return false;

            for (int i = 2; i <= Math.Sqrt(gun); i++)
            {
                if (gun % i == 0) return false;
            }
            return true;
        }
    }

}

