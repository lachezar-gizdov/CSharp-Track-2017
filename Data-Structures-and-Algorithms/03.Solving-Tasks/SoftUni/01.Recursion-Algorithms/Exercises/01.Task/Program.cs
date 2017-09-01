using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Console.WriteLine(FindSum(arr));
            //PrinF(5);

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[8];
            GenBits(vector, n - 1);
        }

        static int FindSum(int[] arr, int index = 0)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + FindSum(arr, index + 1);
        }
        
        static void PrinF(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(new string('-', n));

            PrinF(n - 1);

            Console.WriteLine(new string('*', n));
        }

        static void GenBits(int[] bits, int index)
        {
            if (index == -1)
            {
                Console.WriteLine(string.Join(" ", bits));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                bits[index] = i;
                GenBits(bits, index - 1);
            }
        }
    }
}
