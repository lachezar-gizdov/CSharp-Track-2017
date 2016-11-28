using System;

class BinaryToDecimal
{
    static void Main()
    {
        string bin = Console.ReadLine();

        BinToDec(bin);
    }

    static void BinToDec(string bin)
    {
        long result = 0;

        for (int i = 0; i < bin.Length; i++)
        {
            result += (bin[i] - '0') * (long)Math.Pow(2, (bin.Length - 1 - i));
        }

        Console.WriteLine(result);
    }
}