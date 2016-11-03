using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        long result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            result += (arr[i] - '0') * (long)Math.Pow(2, (arr.Length - 1 - i));
        }

        Console.WriteLine(result);
    }
}