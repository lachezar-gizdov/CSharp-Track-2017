using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int count = 0;

        for (int i = 0; i < n - 2; i++)
        {
            if (nums[i] <= nums[i + 1])
            {
                if (nums[i + 1] <= nums[i + 2])
                {
                    continue;
                }
                else
                {
                    count++;
                    i++;
                }
            }
            else
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}