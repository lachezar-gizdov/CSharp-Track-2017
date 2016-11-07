using System;
using System.Linq;

class GCD
{
    static void Main()
    {
        int[] numbers = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int gcd = 0;

        for (int i = 1; i <= Math.Min(numbers[0], numbers[1]); i++)
        {
            if (numbers[0] % i == 0 && numbers[1] % i == 0)
            {
                gcd = i;
            }
        }

        Console.WriteLine(gcd);
    }
}