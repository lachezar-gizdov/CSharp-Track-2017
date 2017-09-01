using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ReverseArr(arr, 0, arr.Length -1);
            Console.WriteLine(string.Join(" ", arr));
        }

        private static void ReverseArr(int[] arr, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }

            int temp = arr[lo];
            arr[lo] = arr[hi];
            arr[hi] = temp;

            ReverseArr(arr, lo + 1, hi - 1);
        }
    }
}
