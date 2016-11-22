using System;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();

        foreach (char letter in input)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    int index = i;
                    Console.WriteLine(index);
                }
            }
        }
    }
}