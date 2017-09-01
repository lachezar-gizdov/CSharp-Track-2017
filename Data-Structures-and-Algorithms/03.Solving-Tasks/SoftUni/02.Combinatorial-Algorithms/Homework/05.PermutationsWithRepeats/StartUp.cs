using System;
using System.Collections.Generic;

namespace PermutationsWithRepeats
{
    public class StartUp
    {
        public static void Main()
        {
            int[] arr = { 1, 3, 5, 5 };

            GeneratePermutations(arr);
            Console.WriteLine($"Permutations Count: {permutationsCount}");
        }

        private static void GeneratePermutations(int[] arr, int index = 0)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(" ", arr));
                permutationsCount++;
            }
            else
            {
                HashSet<int> used = new HashSet<int>();
                for (int i = index; i < arr.Length; i++)
                {
                    if (!used.Contains(arr[i]))
                    {
                        used.Add(arr[i]);
                        Swap(ref arr[index], ref arr[i]);
                        GeneratePermutations(arr, index + 1);
                        Swap(ref arr[index], ref arr[i]);
                    }
                }
            }
        }

        private static void Swap(ref int i, ref int k)
        {
            if (i == k)
            {
                return;
            }

            int oldKValue = k;
            k = i;
            i = oldKValue;
        }

        private static int permutationsCount = 0;
    }
}
