using System;
using System.Numerics;

class CalculateThree
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger nk = n - k;
        BigInteger nFac = 1;
        BigInteger kFac = 1;
        BigInteger nkFac = 1;
        BigInteger result = 1;

        // N! / (K! * (N - K)!

        for (int i = 2, j = 2; i <= n; i++, j++)
        {
            if (j <= k)
            {
                kFac *= j;
            }
            nFac *= i;
        }

        for (int i = 2; i <= nk; i++)
        {
            nkFac *= i;
        }

        result = nFac / (kFac * nkFac);

        Console.WriteLine(result);
    }
}