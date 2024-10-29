using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp10sorcozum
{
    class soruDokuz
    {
        static void Main()
        {
            int[,] enerjiMatrisi = {
            { 1, 3, 1 },
            { 1, 5, 1 },
            { 4, 2, 1 }
        };

            int enAzEnerji = EnAzEnerjiYolu(enerjiMatrisi);
            Console.WriteLine("En az enerji ile hedefe ulaşma maliyeti: " + enAzEnerji);
        }

        static int EnAzEnerjiYolu(int[,] matris)
        {
            int n = matris.GetLength(0);
            int[,] dp = new int[n, n];

            dp[0, 0] = matris[0, 0];

            for (int i = 1; i < n; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + matris[i, 0];
                dp[0, i] = dp[0, i - 1] + matris[0, i];
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = matris[i, j] + Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1]));
                }
            }

            return dp[n - 1, n - 1];
        }
    }
}

