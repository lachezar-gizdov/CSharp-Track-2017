using System;

class BiggestOfFive
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        // Variant 1 - Shortest
        // Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(d, e), c), b), a));

        // Variant 2
        //double ab = 0;
        //double cd = 0;
        //double max = 0;

        //if (a >= b)
        //{
        //    ab = a;
        //}
        //else
        //{
        //    ab = b;
        //}
        //if (c >= d)
        //{
        //    cd = c;
        //}
        //else
        //{
        //    cd = d;
        //}
        //if (ab >= cd)
        //{
        //    max = ab;
        //}
        //else
        //{
        //    max = cd;
        //}
        //if (max >= e)
        //{
        //    Console.WriteLine(max);
        //}
        //else
        //{
        //    Console.WriteLine(e);
        //}

        // Variant 3
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine(d);
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(e);
        }
    }
}