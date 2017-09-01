using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPathToExit(0, 0);
        }

        static char[,] matrix =
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' ' },
            {'*', '*', ' ', '*', ' ', '*', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            {' ', '*', '*', '*', '*', '*', ' ' },
            {' ', ' ', ' ', ' ', ' ', ' ', 'e' },
        };

        static int moves = 0;

        private static void FindPathToExit(int row, int col)
        {
            if (!InRange(row, col))
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                PrintSolution();
                Console.WriteLine("Moves: {0}", moves);
                moves = 0;
                return;
            }

            if (matrix[row, col] != ' ')
            {
                return;
            }

            matrix[row, col] = '.';
            moves++;

            FindPathToExit(row - 1, col);
            FindPathToExit(row, col + 1);
            FindPathToExit(row + 1, col);
            FindPathToExit(row, col - 1);

            matrix[row, col] = ' ';
        }

        private static void PrintSolution()
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

        private static bool InRange(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
