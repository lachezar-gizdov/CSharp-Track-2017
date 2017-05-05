using System;
using System.Diagnostics;

namespace CompareSimpleMath
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sw = new Stopwatch();

            var simpleMath = new SimpleMath();
            simpleMath.MeasureIntPerformance(sw);
        }

    }

    public class SimpleMath
    {
        public TimeSpan MeasureIntPerformance(Stopwatch sw)
        {
            int valueOne = 42;
            int result = 0;

            sw.Start();

            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    result = result + valueOne;
                }
            }

            sw.Stop();

            return sw.Elapsed;
        }
    }
}
