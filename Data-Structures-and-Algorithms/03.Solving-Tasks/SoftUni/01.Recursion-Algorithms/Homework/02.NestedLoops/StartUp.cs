using System;

namespace NestedLoops
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int index = 0;

            NestedLoopsToRecursion(arr, index, 1, n);
        }

        private static void NestedLoopsToRecursion(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    NestedLoopsToRecursion(arr, index + 1, 1, end);
                }
            }
        }
    }
}
