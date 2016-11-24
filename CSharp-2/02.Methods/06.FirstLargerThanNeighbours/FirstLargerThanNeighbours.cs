using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FirstLargerIndex(nums));
    }

    static int FirstLargerIndex(int[] nums)
    {
        int result = -1;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
            {
                result = i;
                break;
            }
        }

        return result;
    }
}