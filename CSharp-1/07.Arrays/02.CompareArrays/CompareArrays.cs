using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        string isEqual = "Equal";

        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                continue;
            }
            else
            {
                isEqual = "Not equal";
                break;
            }
        }

        Console.WriteLine(isEqual);
    }
}