using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathsBetweenCellsInMatrix
{
    public class StartUp
    {
        public static void Main()
        {
            // read matrix
            // find starting point

            char[,] matrix =
            {
                {' ', ' ', ' ', ' ' },
                {' ', '*', '*', ' ' },
                {' ', '*', '*', ' ' },
                {' ', '*', 'e', ' ' },
                {' ', ' ', ' ', ' ' },
            };

            int[] startPosition = { 0, 0 };
            FindAllPaths(matrix, startPosition[0], startPosition[1]);
            Console.WriteLine($"Paths found: {movesCounter}");
        }

        private static int movesCounter = 0;

        private static void FindAllPaths(char[,] matrix, int row, int col)
        {
            if (!InRange(matrix, row, col))
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                PrintSolution(matrix);
                Console.WriteLine();
                movesCounter++;

                return;
            }

            if (matrix[row, col] != ' ')
            {
                return;
            }

            matrix[row, col] = '.';


            FindAllPaths(matrix, row + 1, col);
            FindAllPaths(matrix, row, col + 1);
            FindAllPaths(matrix, row - 1, col);
            FindAllPaths(matrix, row, col - 1);

            matrix[row, col] = ' ';
        }

        private static bool InRange(char[,] matrix, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }

        private static void PrintSolution(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
