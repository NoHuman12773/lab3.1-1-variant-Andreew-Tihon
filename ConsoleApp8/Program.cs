using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите k:");
                int k = int.Parse(Console.ReadLine());
                double W = 0;
                for (int i = -2; i <= k; i++)
                {
                    if (i == 4) continue;
                    long F = 1;
                    for (int j = 1; j <= i + 3; j++) F *= j;
                    W += (Math.Pow(-1, i) * F) / 2 * (i - 4);
                }
                Console.WriteLine($"W={W:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
