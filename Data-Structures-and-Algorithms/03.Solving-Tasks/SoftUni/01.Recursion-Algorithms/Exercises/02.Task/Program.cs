using System;
using System.Collections.Generic;

namespace _02.Task
{
    public class Program
    {
        public static void Main()
        {
            EightQueens.PutQueens(0);
            Console.WriteLine(EightQueens.solutionsCount);
        }
    }

    public class EightQueens
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        static HashSet<int> attackedCols = new HashSet<int>();
        static HashSet<int> leftDiags = new HashSet<int>();
        static HashSet<int> rightDiags = new HashSet<int>();
        public static int solutionsCount = 0;

        public static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
                Console.WriteLine();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlayQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnMarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnMarkAllAttackedPositions(int row, int col)
        {
            attackedCols.Remove(col);
            leftDiags.Remove(col - row);
            rightDiags.Remove(col + row);
            chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            attackedCols.Add(col);
            leftDiags.Add(col - row);
            rightDiags.Add(col + row);
            chessboard[row, col] = true;
        }

        private static bool CanPlayQueen(int row, int col)
        {
            bool positionTaken = attackedCols.Contains(col) || leftDiags.Contains(col - row) || rightDiags.Contains(col + row);
            return !positionTaken;
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (chessboard[i, j] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            solutionsCount++;
            chessboard = new bool[Size, Size];
        }
    }
}
