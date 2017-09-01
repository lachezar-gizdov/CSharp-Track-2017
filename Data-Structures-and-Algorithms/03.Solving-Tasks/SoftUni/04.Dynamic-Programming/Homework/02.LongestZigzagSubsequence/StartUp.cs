using System;
using System.Collections.Generic;

namespace LongestZigzagSubsequence
{
    class StartUp
    {
        static void Main()
        {
            int[] nums = { 8, 3, 5, 7, 0, 8, 9, 10, 20, 20, 20, 12, 19, 11 };

            int longest = CalculateLongestZigZagSubsequence(nums);
            Console.WriteLine(longest);
        }

        // TODO: Needs updating to list the subsequence not just how long it is.
        private static int CalculateLongestZigZagSubsequence(int[] nums)
        {
            int len = nums.Length;
            int[,] z = new int[len, 2];

            z[0, 0] = 1;
            z[0, 1] = 1;

            int best = 1;

            for (int i = 1; i < len; i++)
            {
                for (int j = i -1; j >= 0; j--)
                {
                    if (nums[j] < nums[i])
                    {
                        z[i, 0] = Math.Max(z[j, 1] + 1, z[i, 0]);
                    }
                    else if (nums[j] > nums[i])
                    {
                        z[i, 1] = Math.Max(z[j, 0] + 1, z[i, 1]);
                    }
                }

                best = Math.Max(best, Math.Max(z[i, 0], z[i, 1]));
            }

            return best;
        }
    }
}
