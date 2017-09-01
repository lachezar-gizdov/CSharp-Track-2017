using System;

namespace CombinationsNoRepeats
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            GenerateCombinationsNoRepetitions(arr, n);
        }

        private static void GenerateCombinationsNoRepetitions(int[] arr, int n, int index = 0, int start = 1)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(arr, n, index + 1, i + 1);
                }
            }
        }
    }
}
