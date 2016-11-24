using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        Array.Sort(nums);

        int index = Array.BinarySearch(nums, k);
        if (index < 0)
        {
            index = ~index;

            Console.WriteLine("{0}", nums[index - 1]);
        }
        else
        {
            Console.WriteLine("{0}", nums[index]);
        }
    }
}