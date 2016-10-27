using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string hex = a.ToString("X");
        string binary = Convert.ToString(a, 2);
        
        Console.WriteLine("{0}|{1}| {2,10:F2}|{3,-10:F3} |", hex.PadRight(10, ' '), binary.PadLeft(10, '0'), b, c);
    }
}