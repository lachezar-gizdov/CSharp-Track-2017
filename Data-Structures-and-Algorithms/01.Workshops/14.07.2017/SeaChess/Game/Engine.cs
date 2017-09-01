using System;
using System.Threading;

namespace Game
{
    public class Engine
    {
        private int player = 1; //By default player 1 is set  
        private int choice; //This holds the choice at which position user want to mark   
        private int flag = 0;

        private Board board;

        public Engine(Board board)
        {
            this.board = board;
        }

        public void Start()
        {
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear  
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//checking the chance of the player  
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                board.Draw(); // calling the board Function  
                choice = int.Parse(Console.ReadLine());//Taking users choice   

                // checking that position where user want to run is marked (with X or O) or not  
                if (board.Arr[choice] != 'X' && board.Arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                    {
                        board.Arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        board.Arr[choice] = 'X';
                        player++;
                    }
                }
                else //If there is any possition where user want to run and that is already marked then show message and load board again  
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, board.Arr[choice]);
                    Thread.Sleep(2000);
                }
                flag = board.CheckWin();// calling of check win  
            } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  

            Console.Clear();// clearing the console  
            board.Draw(); // getting filled board again  

            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner  
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    }
}
