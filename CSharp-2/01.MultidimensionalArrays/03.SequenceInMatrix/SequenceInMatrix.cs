using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];
        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] help = Console.ReadLine().Split(' ').ToArray();

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = help[col];
            }
        }

        Console.WriteLine(Math.Max(MaxSequence(matrix, n, m), Diagonal(matrix, n, m)));
    }

    static int MaxSequence(string[,] matrix, int n, int m)
    {
        int maxCount = 0;
        int currCount = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currCount++;
                }
                maxCount = Math.Max(maxCount, currCount);
                currCount = 1;
            }
        }

        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currCount++;
                }
            }
            maxCount = Math.Max(maxCount, currCount);
            currCount = 1;
        }

        return maxCount;
    }

    static int Diagonal(string[,] matrix, int n, int m)
    {
        int currCount = 1;

        if (n != matrix.GetLength(0) - 1 && m != matrix.GetLength(1) - 1)
        {
            if (matrix[n, m] == matrix[n + 1, m + 1])
            {
                currCount++;
                int tempRow = n;
                int tempCol = m;
                tempRow++;
                tempCol++;
                while (tempRow < matrix.GetLength(0) - 1 && tempCol < matrix.GetLength(1) - 1)
                {
                    if (matrix[tempRow, tempCol] == matrix[tempRow + 1, tempCol + 1])
                    {
                        currCount++;
                    }
                    else
                    {
                        break;
                    }
                    tempRow++;
                    tempCol++;
                }
            }
        }
        return currCount;
    }
}