using System;

class MoonGravity
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;

        Console.WriteLine("{0:F3}", moonWeight);
    }
}