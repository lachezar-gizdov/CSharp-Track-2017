using System;

class DecimalToHex
{
    static void Main()
    {
        {
            string input = Console.ReadLine();
            long temp = 0;
            double result = 0;
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);

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

                result += temp * Math.Pow(16, i);
            }
            Console.WriteLine(result.ToString());
        }
    }
}