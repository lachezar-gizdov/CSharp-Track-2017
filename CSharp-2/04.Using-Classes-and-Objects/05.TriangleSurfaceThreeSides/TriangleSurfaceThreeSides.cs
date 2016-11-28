using System;

class TriangleSurfaceThreeSides
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Surface(a, b, c);
    }

    static void Surface(double a, double b, double c)
    {
        double half = (a + b + c) / 2;

        double result = Math.Sqrt(half * (half - a) * (half - b) * (half - c));

        Console.WriteLine("{0:F2}", result);
    }
}