using System;

class MaximumSum
{
    static void Main()
    {
        int n = 4;
        int digit = 1;
        int Row = n - 1;
        int[,] matrix = new int[n, n];
        int Col = 0;
        int startRow = n - 1;
        int startCol = 0;

        while (digit < n * n)
        {
            if (Row == (n - 1) && Col < (n - 1))        //Filling matrix
            {
                if (digit == 1)
                {
                    matrix[Col, Row] = digit;
                }
                startRow--;
                startCol = 0;
                Row = startRow;
                Col = startCol;
                digit++;
                matrix[Col, Row] = digit;

                while (Row < (n - 1) && Col < (n - 1))
                {
                    Row++;
                    Col++;
                    digit++;
                    matrix[Col, Row] = digit;
                }
            }
            if (Row <= (n - 1) && Col == (n - 1))
            {
                startRow = 0;
                startCol++;
                Row = startRow;
                Col = startCol;
                digit++;
                matrix[Col, Row] = digit;

                while (Col < (n - 1))
                {
                    Col++;
                    Row++;
                    digit++;
                    matrix[Col, Row] = digit;
                }
            }
        }
        for (int c = 0; c < n; c++)           //Printing
        {
            for (int r = 0; r < n; r++)
            {
                Console.Write("{0, 4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();
    }
}