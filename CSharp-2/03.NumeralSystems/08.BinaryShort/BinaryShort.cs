using System;

class BinaryShort
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        DecToBin(n);
    }

    static void DecToBin(short n)
    {
        int num = n;
        string numToBin = string.Empty;
        while (Math.Abs(num) > 0)
        {
            if (num % 2 == 0)
            {
                numToBin = "0" + numToBin;
            }
            else
            {
                numToBin = "1" + numToBin;
            }
            num /= 2;
        }
        if (n >= 0)
        {
            Console.WriteLine(numToBin.PadLeft(16, '0'));
        }
        else
        {
            string complement = GetComplement(numToBin);
            string addOne = GetAddOne(complement);
            Console.WriteLine(addOne.PadLeft(16, '1'));
        }
    }

    static string GetComplement(string numToBin)
    {
        string result = string.Empty;
        for (int i = 0; i < numToBin.Length; i++)
        {
            result += numToBin[i] == '0' ? 1 : 0;
        }
        return result;
    }
    static string GetAddOne(string numToBin)
    {
        int remeinder = 1;
        string addComplement = "";
        for (int i = numToBin.Length - 1; i >= 0; i--)
        {
            int digit = ((numToBin[i] - '0') + remeinder) % 2;
            remeinder = ((numToBin[i] - '0') + remeinder) / 2;
            addComplement = digit + addComplement;
        }
        return addComplement;
    }
}