using System;

class TriangleSurfaceTwoSidesAndAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        Surface(a, b, angle);
    }

    static void Surface(double a, double b, double angle)
    {
        double rad = angle * (Math.PI / 180);
        double sin = Math.Sin(rad);

        double surface = (a * b * sin) / 2;

        Console.WriteLine("{0:F2}", surface);
    }
}