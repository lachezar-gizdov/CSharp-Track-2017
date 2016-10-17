using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1000; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(-(i + 1));
            i++;
        }
    }
}