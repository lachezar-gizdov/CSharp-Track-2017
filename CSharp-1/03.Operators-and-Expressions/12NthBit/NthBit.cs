using System;

class NthBit
{
    static void Main()
    {
        long p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long movedBit = p >> n;
        long result = movedBit & 1;
        Console.WriteLine(result);
    }
}