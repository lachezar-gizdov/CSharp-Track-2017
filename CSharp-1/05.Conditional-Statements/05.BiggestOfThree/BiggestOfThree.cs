using System;

class BiggestOfThree
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        // Console.WriteLine(Math.Max(Math.Max(a, b), c));

        if (a >= b && a >= c)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine(c);
        }

    }
}