using System;
using System.Collections.Generic;
using System.Linq;

namespace Minimum_Absolute_Difference_in_an_Array
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();

            int absMinEl = Math.Abs(numbers[0] - numbers[1]);

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (absMinEl > Math.Abs(numbers[i] - numbers[i +1]))
                {
                    absMinEl = Math.Abs(numbers[i] - numbers[i + 1]);
                }
            }

            Console.WriteLine(absMinEl);
        }
    }
}
