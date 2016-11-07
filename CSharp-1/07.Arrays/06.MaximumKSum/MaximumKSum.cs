using System;

class MaximumKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);

        for (int i = nums.Length - 1; i >= nums.Length - k; i--)
        {
            sum += nums[i];
        }

        Console.WriteLine(sum);
    }
}