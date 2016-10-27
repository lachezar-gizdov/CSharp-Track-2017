using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long a = 0;
        long b = 1;
        long c = 0;

        if (n <= 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.Write("{0}, {1}", a, b);
        }

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(", {0}", c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}