using System;

class ThirdDigit
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine()) / 100;

        if (input % 10 == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", input % 10);
        }
    }
}