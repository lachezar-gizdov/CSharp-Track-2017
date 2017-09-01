using System;

using System.Collections.Generic;

namespace MiniExam1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] jedis = Console.ReadLine().Split(' ');
            var sorted = new Queue<string>();

            foreach (var item in jedis)
            {
                if (item[0] == 'M')
                {
                    sorted.Enqueue(item);
                }

            }

            foreach (var item in jedis)
            {
                if (item[0] == 'K')
                {
                    sorted.Enqueue(item);
                }

            }

            foreach (var item in jedis)
            {
                if (item[0] == 'P')
                {
                    sorted.Enqueue(item);
                }

            }

            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
