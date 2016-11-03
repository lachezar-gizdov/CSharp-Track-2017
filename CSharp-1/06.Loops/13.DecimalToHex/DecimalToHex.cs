using System;

class DecimalToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string result = string.Empty;
        long remainder;
        string letter = string.Empty;
        while (input > 0)
        {
            remainder = input % 16;
            switch (remainder)
            {
                case 10:
                    letter = "A";
                    break;
                case 11:
                    letter = "B";
                    break;
                case 12:
                    letter = "C";
                    break;
                case 13:
                    letter = "D";
                    break;
                case 14:
                    letter = "E";
                    break;
                case 15:
                    letter = "F";
                    break;
                default:
                    letter = remainder.ToString();
                    break;
            }

            result = letter + result;
            input /= 16;
        }
        Console.WriteLine(result);
    }
}