using System;

namespace VariationsNoRepeats
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            bool[] used = new bool[n + 1];

            GenerateVariations(arr, used, n);
        }

        private static void GenerateVariations(int[] arr, bool[] used, int n, int index = 0)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (!used[i])
                    {
                        arr[index] = i;
                        used[i] = true;
                        GenerateVariations(arr, used, n, index + 1);
                        used[i] = false;
                    }
                }
            }
        }
    }
}
