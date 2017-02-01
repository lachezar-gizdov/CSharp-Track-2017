using System;
using System.Linq;

public class GetLargestNumber
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var largest = new GetLargestNumber();

        var result = largest.GetMax(nums);

        Console.WriteLine(result);
    }

    public int GetMax(int[] nums)
    {
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
        }

        return max;
    }
}