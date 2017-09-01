using System;

namespace VariationsRepeats
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];

            GenerateVariations(arr, n);
        }

        private static void GenerateVariations(int[] arr, int n, int index = 0)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    GenerateVariations(arr, n, index + 1);
                }
            }
        }
    }
}
