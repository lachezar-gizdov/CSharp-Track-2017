using System;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string max = string.Empty;

            for (int i = 0; i < n; i++)
            {
                max += "9";
            }

            int maxInt = int.Parse(max);

            for (int i = 1; i <= maxInt; i++)
            {
                string str = i.ToString();
                if (str.Length < n)
                {
                    --maxInt;
                }

                if (str.Contains("00"))
                {
                    --maxInt;
                }
            }

            Console.WriteLine(maxInt);
        }
    }
}
