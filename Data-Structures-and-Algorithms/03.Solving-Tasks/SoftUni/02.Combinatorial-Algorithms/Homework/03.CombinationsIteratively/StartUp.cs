using System;
using System.Linq;

namespace CombinationsIteratively
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = Enumerable.Range(1, n).ToArray();
            GenerateCombinations(arr, k);
        }

        //TODO: Remove repetitions
        private static void GenerateCombinations(int[] arr, int k)
        {
            // allocate an int array to hold the counts:
            int[] pos = new int[k];
            // allocate a char array to hold the current combination:
            int[] combo = new int[k];
            // initialize to the first value:
            for (int i = 0; i < k; i++)
            {
                combo[i] = arr[0];
            }

            while (true)
            {
                Console.WriteLine(string.Join(" ", combo));

                // move on to the next combination:
                int place = k - 1;
                while (place >= 0)
                {
                    if (++pos[place] == arr.Length)
                    {
                        // overflow, reset to zero
                        pos[place] = 0;
                        combo[place] = arr[0];
                        place--; // and carry across to the next value
                    }
                    else
                    {
                        // no overflow, just set the char value and we're done
                        combo[place] = arr[pos[place]];
                        break;
                    }
                }
                if (place < 0)
                    break;  // overflowed the last position, no more combinations
            }
        }
    }
}
