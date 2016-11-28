using System;

class HexToBinary
{
    static void Main()
    {
        string hex = Console.ReadLine();

        HexToBin(hex);
    }

    static void HexToBin(string hex)
    {
        long temp = 0;
        string result = string.Empty;
        char[] arr = hex.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            switch (arr[i])
            {
                case 'A':
                    temp = 10;
                    break;
                case 'B':
                    temp = 11;
                    break;
                case 'C':
                    temp = 12;
                    break;
                case 'D':
                    temp = 13;
                    break;
                case 'E':
                    temp = 14;
                    break;
                case 'F':
                    temp = 15;
                    break;
                default:
                    temp = arr[i] - '0';
                    break;
            }

            result += DecToBin(temp);
        }
        Console.WriteLine(result.TrimStart('0'));
    }

    static string DecToBin(long temp)
    {
        string result = string.Empty;
        if (temp == 0)
        {
            result = "0000";
        }
        else
        {
            while (temp > 0)
            {
                if (temp % 2 == 0)
                {
                    result = "0" + result;
                }
                else
                {
                    result = "1" + result;
                }
                temp /= 2;
            }

            result = result.PadLeft(4, '0');
        }

        return result;
    }
}