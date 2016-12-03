using System;

class FormatNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        Format(inputNumber);
    }

    static void Format(int inputNumber)
    {
        Console.WriteLine("{0:D}", inputNumber);
        Console.WriteLine("{0:X}", inputNumber);
        Console.WriteLine("{0:P}", inputNumber);
        Console.WriteLine("{0:E}", inputNumber);
    }
}