using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            fibs = new long[2 * n];
            Console.WriteLine(Fibonnaci(n));
        }

        static long[] fibs;

        private static long Fibonnaci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                if (fibs[n] != 0)
                {
                    return fibs[n];
                }
            }

            fibs[n] = Fibonnaci(n - 1) + Fibonnaci(n - 2);
            return Fibonnaci(n - 1) + Fibonnaci(n - 2);
        }
    }
}
