using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        Array.Reverse(input);

        foreach (string word in input)
        {
            Console.Write("{0} ", word);
        }
        Console.WriteLine();
    }
}