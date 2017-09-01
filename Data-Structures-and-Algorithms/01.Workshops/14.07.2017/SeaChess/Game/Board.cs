using System;

namespace Game
{
    public class Board
    {
        private char[] arr;

        public char[] Arr
        {
            get
            {
                return this.arr;
            }

            set
            {
                this.arr = value;
            }
        }

        public Board()
        {
            this.arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        public void Draw()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", this.Arr[1], this.Arr[2], this.Arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", this.Arr[4], this.Arr[5], this.Arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", this.Arr[7], this.Arr[8], this.Arr[9]);
            Console.WriteLine("     |     |      ");
        }

        public int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row   
            if (Arr[1] == Arr[2] && Arr[2] == Arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row   
            else if (Arr[4] == Arr[5] && Arr[5] == Arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row   
            else if (Arr[6] == Arr[7] && Arr[7] == Arr[8])
            {
                return 1;
            }
            #endregion

            #region vertical Winning Condtion
            //Winning Condition For First Column       
            else if (Arr[1] == Arr[4] && Arr[4] == Arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column  
            else if (Arr[2] == Arr[5] && Arr[5] == Arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column  
            else if (Arr[3] == Arr[6] && Arr[6] == Arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (Arr[1] == Arr[5] && Arr[5] == Arr[9])
            {
                return 1;
            }
            else if (Arr[3] == Arr[5] && Arr[5] == Arr[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match  
            else if (Arr[1] != '1' && Arr[2] != '2' && Arr[3] != '3' && Arr[4] != '4' && Arr[5] != '5' && Arr[6] != '6' && Arr[7] != '7' && Arr[8] != '8' && Arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    }
}
