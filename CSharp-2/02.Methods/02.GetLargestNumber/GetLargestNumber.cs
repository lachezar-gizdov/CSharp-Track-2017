using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(GetMax(nums));
    }

    static int GetMax(int[] nums)
    {
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
        }

        return max;
    }
}