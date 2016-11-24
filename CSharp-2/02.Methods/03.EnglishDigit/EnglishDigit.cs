using System;
using System.Linq;

class EnglishDigit
{
    static void Main()
    {
        int[] number = Console.ReadLine().ToString().Select(o => Convert.ToInt32(o)).ToArray();

        Console.WriteLine(LastDigit(number));
    }

    static string LastDigit(int[] number)
    {
        string result = string.Empty;

        switch (number[number.Length - 1] - '0')
        {
            case 0:
                result = "zero";
                break;
            case 1:
                result = "one";
                break;
            case 2:
                result = "two";
                break;
            case 3:
                result = "three";
                break;
            case 4:
                result = "four";
                break;
            case 5:
                result = "five";
                break;
            case 6:
                result = "six";
                break;
            case 7:
                result = "seven";
                break;
            case 8:
                result = "eight";
                break;
            case 9:
                result = "nine";
                break;
        }

        return result;
    }
}
