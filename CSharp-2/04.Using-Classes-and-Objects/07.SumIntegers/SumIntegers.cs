using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        SumOfElements(input);
    }

    private static void SumOfElements(int[] input)
    {
        long sum = 0;

        foreach (int num in input)
        {
            sum += num;
        }

        Console.WriteLine(sum);
    }
}