using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        string lenghts = Console.ReadLine();

        int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        foreach (int sum in SumOfArrayElements(firstArr, secondArr))
        {
            Console.Write("{0} ", sum);
        }
        Console.WriteLine();
    }

    static int[] SumOfArrayElements(int[] firstArr, int[] secondArr)
    {
        int[] resultArr = new int[Math.Max(firstArr.Length, secondArr.Length)];

        return resultArr;
    }
}