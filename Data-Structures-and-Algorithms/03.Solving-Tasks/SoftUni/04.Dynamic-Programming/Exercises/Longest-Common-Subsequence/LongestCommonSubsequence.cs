namespace Longest_Common_Subsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestCommonSubsequence
    {
        public static void Main()
        {
            var firstStr = "tree";
            var secondStr = "team";

            var lcs = FindLongestCommonSubsequence(firstStr, secondStr);

            Console.WriteLine("Longest common subsequence:");
            Console.WriteLine("first  = {0}", firstStr);
            Console.WriteLine("second = {0}", secondStr);
            Console.WriteLine("lcs    = {0}", lcs);
        }

        public static string FindLongestCommonSubsequence(string firstStr, string secondStr)
        {
            int firstStrLen = firstStr.Length + 1;
            int secondStrLen = secondStr.Length + 1;
            int[,] lcs = new int[firstStrLen, secondStrLen];

            for (int i = 1; i < firstStrLen; i++)
            {
                for (int j = 1; j < secondStrLen; j++)
                {
                    if (firstStr[i - 1] == secondStr[j - 1])
                    {
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }
            }

            return RetrieveLCS(firstStr, secondStr, lcs);
        }

        private static string RetrieveLCS(string firstStr, string secondStr, int[,] lcs)
        {
            List<char> result = new List<char>();

            int i = firstStr.Length - 1;
            int j = secondStr.Length - 1;
            while (i >= 0 && j >= 0)
            {
                if (firstStr[i] == secondStr[j])
                {
                    result.Add(firstStr[i]);
                    i--;
                    j--;
                }
                else if (lcs[i - 1, j] == lcs[i, j])
                {
                    i--;
                }
                else
                {
                    j--;
                }
            }

            result.Reverse();
            return string.Join("", result);
        }
    }
}
