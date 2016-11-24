using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        string[] number = Console.ReadLine().Split('.').ToArray();

        Console.WriteLine(Reverse(number));

    }

    static string Reverse(string[] number)
    {
        string result = string.Empty;

        if (number.Length == 1)
        {
            char[] arr = number[0].ToCharArray();
            Array.Reverse(arr);

            foreach (var digit in arr)
            {
                result += digit;
            }
        }
        else
        {
            for (int i = 0; i < number.Length; i++)
            {
                char[] arr = number[i].ToCharArray();
                Array.Reverse(arr);

                foreach (var digit in arr)
                {
                        result += digit;
                }

                number[i] = result;
                result = string.Empty;
            }
            Array.Reverse(number);
            result = string.Join(".", number);
        }

        return result;
    }
}