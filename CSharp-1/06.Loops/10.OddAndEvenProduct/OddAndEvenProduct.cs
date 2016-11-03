using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long sumOfEven = 1;
        long sumOfOdd = 1;

        long[] nums = Console
            .ReadLine()
            .Split()
            .Select(long.Parse).ToArray();

        for (long i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                sumOfEven *= nums[i];
            }
            else
            {
                sumOfOdd *= nums[i];
            }
        }

        if (sumOfEven == sumOfOdd)
        {
            Console.WriteLine("yes {0}", sumOfEven);
        }
        else
        {
            Console.WriteLine("no {0} {1}", sumOfEven, sumOfOdd);
        }
    }
}