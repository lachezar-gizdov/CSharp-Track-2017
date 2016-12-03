using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();

        //ReverseStr(input); //slower, but less memory

        ReverseStrSE(input); //faster, but more memory
    }

    //variant 1
    static void ReverseStr(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);

        foreach (char ch in arr)
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }


    //variant 2
    static void ReverseStrSE(string input)
    {
        StringBuilder result = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }

        Console.WriteLine(result);
    }
}