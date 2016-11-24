using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(LargerCount(nums));
    }

    static int LargerCount(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                count++;
            }
        }

        return count;
    }
}