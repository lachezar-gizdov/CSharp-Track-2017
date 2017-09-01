using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Task
{
    static class Task
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] specialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add((i + 1));
            }



            //SwapWithSplit(n, specialNumbers);
        }

        // Working for 1 special number
        public static void SwapWithSplit(int n, int[] specialNumbers)
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < n; i++)
            {
                numbers.Add((i + 1).ToString());
            }

            string swaped = string.Empty;

            for (int i = 0; i < specialNumbers.Count(); i++)
            {
                string[] str = string.Join(" ", numbers)
                    .Split(new string[] { specialNumbers[i].ToString() }, StringSplitOptions.None)
                    .ToArray();
                swaped = string.Join(" ", str[1] + " " + specialNumbers[i] + " " + str[0]).Trim();
                numbers = swaped.Split(' ').ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static List<int> Swap(List<int> numbers, int n, int[] x)
        {
            //MAGIC

            //Duno

            Swap(numbers, n, x);

            return numbers;
        }
    }
}
