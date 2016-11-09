using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine().ToCharArray();
        char[] secondArray = Console.ReadLine().ToCharArray();
        char[] shorter;
        bool isEqual = true;

        if (firstArray.Length > secondArray.Length)
        {
            shorter = secondArray;
        }

        else
        {
            shorter = firstArray;
        }

        for (int i = 0; i < shorter.Length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                continue;
            }
            else
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("<");
                }
                isEqual = false;
                break;
            }
        }
        if (isEqual)
        {
            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
            else if (firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("=");
            }
        }
    }
}