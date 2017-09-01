using System;
using System.Collections.Generic;
using System.Linq;

namespace DividingPresents
{
    public class StartUp
    {
        //Solution by Raskolnikov@SoftUni
        public static void Main()
        {
            int[] values = new int[] { 7, 17, 45, 91, 11, 32, 102, 33, 6, 3 };
            List<int> alanPresents = new List<int>();
            Dictionary<int, int> possibleSums = new Dictionary<int, int>
            {
                { 0, 0 }
            };

            for (int i = 0; i < values.Length; i++)
            {
                Dictionary<int, int> newSums = new Dictionary<int, int>();
                foreach (int sum in possibleSums.Keys)
                {
                    int newSum = sum + values[i];
                    if (!possibleSums.ContainsKey(newSum))
                    {
                        newSums.Add(newSum, values[i]);
                    }
                }

                foreach (var newSum in newSums)
                {
                    if (!possibleSums.ContainsKey(newSum.Key))
                    {
                        possibleSums.Add(newSum.Key, newSum.Value);
                    }
                }
            }

            int totalSum = values.Sum();
            int minDiff = int.MaxValue;
            int bestSum = 0;
            int alanSum = 0;
            foreach (var possSum in possibleSums)
            {
                if (possSum.Key < totalSum)
                {
                    int bob = totalSum - possSum.Key;
                    int diff = bob - possSum.Key;
                    if (diff >= 0 && minDiff > diff)
                    {
                        minDiff = diff;
                        bestSum = possSum.Key;
                        alanSum = bestSum;
                    }
                }
            }

            List<int> alan = new List<int>();
            int currentPresent = possibleSums[bestSum];

            while (bestSum > 0)
            {
                alan.Add(currentPresent);
                bestSum -= currentPresent;
                currentPresent = possibleSums[bestSum];
            }

            Console.WriteLine("Difference: {0}", minDiff);
            Console.WriteLine($"Alan: {alanSum} Bob: {totalSum - alanSum}");
            Console.WriteLine("Alan takes: {0}", string.Join(", ", alan));
            Console.WriteLine("Bob takes the rest.");
        }
    }
}
