using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? d = null;

        Console.WriteLine(a);
        Console.WriteLine(d);

        a += 5;
        d += null;

        Console.WriteLine(a);
        Console.WriteLine(d);
    }
}