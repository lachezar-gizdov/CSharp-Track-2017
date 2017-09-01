using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsWithoutRepetition
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            int index = 0;

            GenCombinationsWithoutRepetitions(arr, index, 1, n);
        }

        private static void GenCombinationsWithoutRepetitions(int[] arr, int index, int start, int end)
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
                    GenCombinationsWithoutRepetitions(arr, index + 1, i + 1, end);
                }
            }
        }
    }
}
