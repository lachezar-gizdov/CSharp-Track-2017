using System;

namespace BinomialCoefficients
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            FindBinomialCoefficient(n, k);
        }

        private static void FindBinomialCoefficient(long n, long k)
        {
            double sum = 0;
            for (long i = 0; i < k; i++)
            {
                sum += Math.Log10(n - i);
                sum -= Math.Log10(i + 1);
            }
            Console.WriteLine(Math.Pow(10, sum));
        }
    }
}
