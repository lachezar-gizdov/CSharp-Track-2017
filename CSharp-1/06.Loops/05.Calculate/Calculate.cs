using System;

class Calculate
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        double f = 1;

        // S = 1 + 1! / x + 2! / x2 ... + n! / xN

        for (int i = 1; i <= n; i++)
        {
            f *= i;
            sum += f / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}