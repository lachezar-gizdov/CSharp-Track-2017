using System;
using System.Linq;

namespace MiniExam
{
    class Program
    {
        static void Main()
        {
            double[] firstLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondLine = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double avgSpeed = (firstLine[2] + secondLine[2]) / 2;
            double x1 = firstLine[0];
            double x2 = firstLine[1];
            double y1 = secondLine[0];
            double y2 = secondLine[1];
            double result = Math.Sqrt(((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))) / avgSpeed;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
