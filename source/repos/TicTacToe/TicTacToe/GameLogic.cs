using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameLogic
    {
        public string CurrentPlayer { get; set; } = x;
        private const string x = "x";
        private const string o = "o";
        private string[,] Board = new string[3, 3];

        public void SetNextPlayer()
        {
            if(CurrentPlayer == x)
            {
                CurrentPlayer = o;
            }
            else
            {
                CurrentPlayer = x;
            }
        }

        public bool PlayerWin()
        {
            //we want to check the horizontal row
            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[i, 2]))
                {
                    if (Board[i, 0] == Board[i, 1] && Board[i, 0] == Board[i, 2])
                    {
                        return true;
                    }
                }
            }
            //we want to check the columns
            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0, i]))
                {
                    if (Board[0, i] == Board[1, i] && Board[0, i] == Board[2, i])
                    {
                        return true;
                    }
                }
            }
            //diagonal

            if (!String.IsNullOrWhiteSpace(Board[1,1]))
            {
                if (Board[0,0] == Board[1,1] && Board[1,1] == Board[2,2])
                {
                    return true;
                }
                if (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0])
                {
                    return true;
                }
            }

                return false;
        }
        internal void UpdateBoard(Position position, string value)
        {
            Board[position.x, position.y] = value;
        }
    }
}
