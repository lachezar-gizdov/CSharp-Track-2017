namespace Longest_Increasing_Subsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestIncreasingSubsequence
    {
        static void Main()
        {
            int[] nums = { 3, 4, 8, 1, 2, 4, 32, 6, 2, 5, 33, 4, 38, 22 };
            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];

            int bestIndex = CalculateLongestIncreasingSubsequence(nums, len, prev);

            Console.WriteLine("seq[]  = " + String.Join(", ", nums));
            Console.WriteLine("len[]  = " + String.Join(", ", len));

            PrintLongestIncreasingSubsequence(nums, prev, bestIndex);
        }

        private static int CalculateLongestIncreasingSubsequence(
            int[] nums, int[] len, int[] prev)
        {
            int bestLen = 0;
            int bestIndex = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i <= x - 1; i++)
                {
                    if (nums[i] < nums[x] && 1 + len[i] > len[x])
                    {
                        len[x] = 1 + len[i];
                        prev[x] = i;
                        if (len[x] > bestLen)
                        {
                            bestLen = len[x];
                            bestIndex = x;
                        }
                    }
                }
            }
            return bestIndex;
        }

        static void PrintLongestIncreasingSubsequence(int[] seq, int[] prev, int index)
        {
            List<int> result = new List<int>();
            while (index != -1)
            {
                result.Add(seq[index]);
                index = prev[index];
            }
            result.Reverse();
            Console.WriteLine("subsequence = [{0}]", string.Join(", ", result));
        }
    }
}
