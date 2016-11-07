using System;

class AllocateArray
{
    static void Main()
    {
        int[] nums = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i * 5;
        }

        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
    }
}