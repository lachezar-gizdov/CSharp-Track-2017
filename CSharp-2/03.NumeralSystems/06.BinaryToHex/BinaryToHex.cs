using System;

class BinaryToHex
{
    static void Main()
    {
        string bin = Console.ReadLine();

        BinToHex(bin);
    }

    static void BinToHex(string bin)
    {
        char[] arr = bin.ToCharArray();
        string temp = string.Empty;

        for (int i = arr.Length - 1; i >= 0; i++)
        {
            temp = arr[i] + temp;
            if (temp.Length == 4)
            {
                long result = 0;

                for (int j = 0; j < bin.Length; j++)
                {
                    result += (temp[j] - '0') * (long)Math.Pow(2, (temp.Length - 1 - j));
                }
            }
        }

    }

    static void DecToHex(long result)
    {
        string result1 = string.Empty;
        long remainder;
        string letter = string.Empty;
        while (result > 0)
        {
            remainder = result % 16;
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

            result1 = letter + result1;
            result /= 16;
        }
        Console.WriteLine(result);
    }
}