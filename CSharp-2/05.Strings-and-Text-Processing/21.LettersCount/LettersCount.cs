using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter some text and the program will calculate the number of unique letters used: ");
        string input = Console.ReadLine().ToLower();

        char[] arr = input.ToCharArray();
        HashSet<char> hash = new HashSet<char>(arr);
        int count = 0;
        int c = 0;

        int[] counts = new int[hash.Count];

        foreach (char ch in hash)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (ch == input[i])
                {
                    count++;
                }
            }
            counts[c] = count;
            count = 0;
            c++;
        }

        char[] result = new char[hash.Count];
        hash.CopyTo(result);
        int lettersCount = 0;
        Console.WriteLine("--------------Breakdown------------");

        for (int i = 0; i < hash.Count; i++)
        {
            if ((result[i] >= 97 && result[i] <= 122) || (result[i] >= 65 && result[i] <= 90))
            {
                Console.WriteLine("Number of letter {0} = {1}", result[i], counts[i]);
                lettersCount++;
            }
        }
        Console.WriteLine("Number of different letters used: {0}", lettersCount);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Press any key to exit :) Thank you!");
        Console.ReadKey();
    }
}