using System;

class DecimalToBinary
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());

        DecToBin(dec);
    }

    static void DecToBin(long dec)
    {
        string result = string.Empty;
        while (dec > 0)
        {
            if (dec % 2 == 0)
            {
                result = "0" + result;
            }
            else
            {
                result = "1" + result;
            }
            dec /= 2;
        }

        Console.WriteLine(result);
    }
}