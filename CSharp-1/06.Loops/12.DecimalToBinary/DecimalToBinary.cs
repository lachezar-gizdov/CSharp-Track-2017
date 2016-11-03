using System;

class DecimalToBinary
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string result = string.Empty;

        while (input > 0)
        {
            if (input % 2 == 0)
            {
                result = "0" + result;
            }
            else
            {
                result = "1" + result;
            }
            input /= 2;
        }

        Console.WriteLine(result);
    }
}