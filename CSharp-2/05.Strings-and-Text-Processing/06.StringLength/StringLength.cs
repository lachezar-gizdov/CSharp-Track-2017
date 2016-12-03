using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        StringBuilder input = new StringBuilder(Console.ReadLine());

        StringFill(input);
    }

    static void StringFill(StringBuilder input)
    {
        string result = string.Empty;
        if (input.Length == 20)
        {
            result = input.ToString();
        }
        else
        {
            int count = 20 - input.Length;
            input.Append('*', count);
            result = input.ToString();
        }

        Console.WriteLine(result);
    }
}