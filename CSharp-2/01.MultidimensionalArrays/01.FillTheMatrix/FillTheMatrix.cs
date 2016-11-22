using System;

class FillTheMatrix
{
    static int count = 1;

    static void MatrixA(int n, int[,] matrix)
    {
        //Filing the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i,j] =j + count;
                count += n - 1;
            }
            count = i + 2;
        }

        //Printing the matrix
        PrintMatrix(matrix, n);
    }

    static void MatrixB(int n, int[,] matrix)
    {
        //Filing the matrix
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }

        //Printing the matrix
        PrintMatrix(matrix, n);
    }

    static void MatrixC(int n, int[,] matrix)
    {
        int Row = n - 1;
        int Col = 0;
        int startRow = n - 1;
        int startCol = 0;

        //Filing the matrix
        while (count < n * n)
        {
            if (Row == (n - 1) && Col < (n - 1))        //Filling matrix
            {
                if (count == 1)
                {
                    matrix[Row, Col] = count;
                }
                startRow--;
                startCol = 0;
                Row = startRow;
                Col = startCol;
                count++;
                matrix[Row, Col] = count;

                while (Row < (n - 1) && Col < (n - 1))
                {
                    Row++;
                    Col++;
                    count++;
                    matrix[Row, Col] = count;
                }
            }
            if (Row <= (n - 1) && Col == (n - 1))
            {
                startRow = 0;
                startCol++;
                Row = startRow;
                Col = startCol;
                count++;
                matrix[Row, Col] = count;

                while (Col < (n - 1))
                {
                    Col++;
                    Row++;
                    count++;
                    matrix[Row, Col] = count;
                }
            }
        }

        //Printing the matrix
        PrintMatrix(matrix, n);
    }

    static void MatrixD(int n, int[,] matrix)
    {
        //Filing the matrix
        int offset = 0;
        int col = 0;
        int row = 0;

        while (count <= n * n)
        {
            for (row = offset ; row < n - offset; row++)
            {
                col = offset;
                matrix[row, col] = count;
                count++;
            }
            for (col = 1 + offset; col < n - offset; col++)
            {
                row = n - 1 - offset;
                matrix[row, col] = count;
                count++;
            }
            for (row = n - 2 - offset; row >= offset; row--)
            {
                col = n - 1 - offset;
                matrix[row, col] = count;
                count++;
            }
            for (col = n - 2 - offset; col >= offset + 1; col--)
            {
                row = offset;
                matrix[row, col] = count;
                count++;
            }
            offset++;
        }

        //Printing the matrix
        PrintMatrix(matrix, n);
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}", matrix[i, j]);

                if (j + 1 == matrix.GetLength(0))
                {
                    break;
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        char ch = char.Parse(Console.ReadLine());

        if (ch == 'a')
        {
            MatrixA(n, matrix);
        }
        if (ch == 'b')
        {
            MatrixB(n, matrix);
        }
        if (ch == 'c')
        {
            MatrixC(n, matrix);
        }
        if (ch == 'd')
        {
            MatrixD(n, matrix);
        }
    }
}