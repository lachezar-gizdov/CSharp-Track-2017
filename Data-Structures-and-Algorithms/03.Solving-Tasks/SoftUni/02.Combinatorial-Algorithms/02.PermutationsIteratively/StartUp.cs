using System;
using System.Linq;

namespace PermutationsIteratively
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Enumerable.Range(1, n).ToArray();

            GeneratePermutations(arr);
        }

        private static void GeneratePermutations(int[] arr)
        {
            int n = arr.Length;
            int[] p = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                p[i] = i;
            }
            int index = 0;
            int j = 0;
            while (index < n)
            {
                p[index]--;
                if (index % 2 != 0)
                {
                    j = p[index];
                }
                else
                {
                    j = 0;
                }

                Swap(ref arr[j], ref arr[index]);
                index = 1;
                while (p[index] == 0)
                {
                    p[index] = index;
                    index++;
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
    }
}
