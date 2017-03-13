namespace Games
{
    using Minesweeper.Models;
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = createPlayingField();
            char[,] bombs = placeBombs();
            int counter = 0;
            bool bang = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int colomn = 0;
            bool flag = true;
            const int max = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Let's play Minesweeper! Try to avoid the mines!");
                    Console.WriteLine("Commands during the game: 'top' - show the current Scoreboard, 'restart' - start a new game, 'exit' - to exit the game.");

                    dumpp(field);
                    flag = false;
                }

                Console.Write("Enter row and colomn separated by a signle space : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out colomn) &&
                        row <= field.GetLength(0) && colomn <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ScoreBoard(champions);
                        break;
                    case "restart":
                        field = createPlayingField();
                        bombs = placeBombs();
                        dumpp(field);
                        bang = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombs[row, colomn] != '*')
                        {
                            if (bombs[row, colomn] == '-')
                            {
                                tisinahod(field, bombs, row, colomn);
                                counter++;
                            }
                            if (max == counter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                dumpp(field);
                            }
                        }
                        else
                        {
                            bang = true;
                        }
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Error! Invalid command.");
                        Console.WriteLine();

                        break;
                }

                if (bang)
                {
                    dumpp(bombs);
                    Console.WriteLine();
                    Console.Write("Ouch! You hit a mine. Score: {0}. Enter your nickname: ", counter);

                    string nickName = Console.ReadLine();
                    Score t = new Score(nickName, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    ScoreBoard(champions);

                    field = createPlayingField();
                    bombs = placeBombs();
                    counter = 0;
                    bang = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nice job! You opened 35 cells without hitting a mine!");

                    dumpp(bombs);
                    Console.WriteLine("Enter your nickname: ");
                    string name = Console.ReadLine();
                    Score score = new Score(name, counter);
                    champions.Add(score);
                    ScoreBoard(champions);
                    field = createPlayingField();
                    bombs = placeBombs();
                    counter = 0;
                    flag2 = false;
                    flag = true;
                }
            }

            while (command != "exit");

            Console.Read();
        }

        private static void ScoreBoard(List<Score> score)
        {
            Console.WriteLine("\nScore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, score[i].Name, score[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ScoreBoard!\n");
            }
        }

        private static void tisinahod(char[,] board, char[,] binbs, int row, int colomn)
        {
            char colkobinbs = Move(binbs, row, colomn);
            binbs[row, colomn] = colkobinbs;
            board[row, colomn] = colkobinbs;
        }

        private static void dumpp(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] createPlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] placeBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random randomNumber = new Random();
                int numberToAdd = randomNumber.Next(50);
                if (!bombs.Contains(numberToAdd))
                {
                    bombs.Add(numberToAdd);
                }
            }

            foreach (int bomb in bombs)
            {
                int col = (bomb / cols);
                int row = (bomb % cols);
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                playField[col, row - 1] = '*';
            }

            return playField;
        }

        private static void Calculations(char[,] board)
        {
            int col = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char move = Move(board, i, j);
                        board[i, j] = move;
                    }
                }
            }
        }

        private static char Move(char[,] board, int row, int col)
        {
            int counter = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    counter++;
                }
            }
            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    counter++;
                }
            }
            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    counter++;
                }
            }
            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}