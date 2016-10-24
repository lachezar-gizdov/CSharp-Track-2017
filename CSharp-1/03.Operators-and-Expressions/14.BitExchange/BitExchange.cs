using System;

class BitExchange
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int p1 = 3;
        int p2 = 24;

        int mask1 = 7 << p1;
        int mask2 = 7 << p2;

        int getNumbers1 = num & mask1;
        int getNumbers2 = num & mask2;
        int change = (num & ~mask1) & ~mask2;

        int mask3 = (getNumbers1 >> p1) << p2;
        int mask4 = (getNumbers2 >> p2) << p1;
        int result = (change | mask3) | mask4;

        Console.WriteLine(result);
    }
}