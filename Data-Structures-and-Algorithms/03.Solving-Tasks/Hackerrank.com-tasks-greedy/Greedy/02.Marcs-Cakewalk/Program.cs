using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcs_Cakewalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort((x, y )=> y - x);
            double miles = 0;

            for (int i = 0; i < n; i++)
            {
                miles += (numbers[i] * Math.Pow(2, i));
            }

            Console.WriteLine(miles);
        }
    }
}
