using System;

class TriangleSurface
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double alt = double.Parse(Console.ReadLine());

        Surface(side, alt);
    }

    static void Surface(double side, double alt)
    {
        double result = 0;

        result = (alt * side) / 2;

        Console.WriteLine("{0:F2}", result);
    }
}