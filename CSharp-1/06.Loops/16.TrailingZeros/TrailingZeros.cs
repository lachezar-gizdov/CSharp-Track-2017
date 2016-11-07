using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nF = 1;
        int zeros = 0;

        for (int i = 2; i <= n; i++)
        {
            nF *= i;
        }

        char[] arr = nF.ToString().ToCharArray();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == '0')
            {
                zeros++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(zeros);
    }
}