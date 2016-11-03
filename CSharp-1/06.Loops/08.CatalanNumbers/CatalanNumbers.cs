using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal result = 1;

        if (n != 0)
        {                //10   /      6 * 5
            result = (1 * 2 * n) / ((n + 1) * n);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}