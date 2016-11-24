using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(CountAppearces(nums, x));

    }

    static int CountAppearces(int[] nums, int x)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == x)
            {
                count++;
            }
        }

        return count;
    }
}