using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int count = 1;
        int maxCount = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                count++;
                maxCount = Math.Max(count, maxCount);
            }
            else
            {
                count = 1;
            }
        }

        Console.WriteLine(maxCount);
    }
}