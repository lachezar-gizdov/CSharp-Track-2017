using System;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool test = true;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (test)
            {
                Console.Write(input[i]);
            }

            if (input[i] == input[i+1])
            {
                test = false;
            }
            else
            {
                test = true;
            }

            if (i + 1 == input.Length - 1)
            {
                if (input[input.Length - 1] != input[i])
                {
                    Console.Write(input[input.Length - 1]);
                }
            }
        }
        Console.WriteLine();
    }
}