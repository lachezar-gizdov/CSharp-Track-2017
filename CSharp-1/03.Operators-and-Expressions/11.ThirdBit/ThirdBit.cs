using System;

class ThirdBit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine()) >> 3;
        int result = num & 1;
        Console.WriteLine(result);
    }
}