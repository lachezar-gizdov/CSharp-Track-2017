using System;
using System.Linq;

namespace Permutations
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Enumerable.Range(1, n).ToArray();

            GeneratePermutations(arr);
            Console.WriteLine($"Permutatios: {permutationsCount}");
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
                for (int i = index; i < arr.Length; i++)
                {
                    Swap(ref arr[index], ref arr[i]);
                    GeneratePermutations(arr, index + 1);
                    Swap(ref arr[index], ref arr[i]);
                }
            }
        }

        private static void Swap(ref int i,ref  int k)
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
