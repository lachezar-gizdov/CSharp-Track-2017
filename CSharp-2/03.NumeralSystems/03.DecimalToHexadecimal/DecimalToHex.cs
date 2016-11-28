using System;

class DecimalToHex
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());

        DecToHex(dec);
    }

    static void DecToHex(long dec)
    {
        string result = string.Empty;
        long remainder;
        string letter = string.Empty;
        while (dec > 0)
        {
            remainder = dec % 16;
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
            dec /= 16;
        }
        Console.WriteLine(result);
    }
}