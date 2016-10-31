using System;

class MMSA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] nums = new double[n];
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = double.Parse(Console.ReadLine());
            sum += nums[i];
        }

        double min = nums[0];
        double max = nums[0];
        double avg = sum / n;

        foreach (double number in nums)
        {
            if (min >= number)
            {
                min = number;
            }

            if (max <= number)
            {
                max = number;
            }
        }

        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}