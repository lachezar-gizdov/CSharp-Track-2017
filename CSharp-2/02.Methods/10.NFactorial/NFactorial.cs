using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(n));
    }

    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}