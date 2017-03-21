namespace StatisticsHomework
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] numbers)
        {
            PrintMax(numbers);

            PrintMin(numbers);

            PrintAvg(numbers);
        }

        private void PrintMax(double[] numbers)
        {
            double max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                Console.WriteLine(max);
            }
        }

        private void PrintMin(double[] numbers)
        {
            double min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                Console.WriteLine(min);
            }
        }

        private void PrintAvg(double[] numbers)
        {
            double sum = 0;
            double numbersCount = numbers.Length;

            for (int i = 0; i < numbersCount; i++)
            {
                sum += numbers[i];
            }

            double avg = sum / numbersCount;

            Console.WriteLine(avg);
        }
    }
}
