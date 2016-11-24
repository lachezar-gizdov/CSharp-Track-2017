using System;
using System.Linq;

class MaximumSum
{
    static int GetSum(int[,] matrix, int col, int row, int square)
    {
        int sum = 0;
        for (int i = 0; i < square; i++)
        {
            for (int j = 0; j < square; j++)
            {
                sum += matrix[col + i, row + j];
            }
        }
        return sum;
    }

    static void Main()
    {
        int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];
        int[,] matrix = new int[n, m];
        int currSum = 0;
        int maxSum = int.MinValue;
        int square = 3;

        for (int row = 0; row < n; row++)
        {
            int[] help = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = help[col];
            }
        }

        for (int col = 0; col <= n - square; col++)
        {
            for (int row = 0; row <= m - square; row++)
            {
                currSum = GetSum(matrix, col, row, square);
                maxSum = Math.Max(maxSum, currSum);
            }
        }

        Console.WriteLine(maxSum);
    }
}