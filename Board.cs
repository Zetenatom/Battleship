using Battleship.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Models.Board
{
    public class Board
    {
        private static TileStates[,] battleBoard;

        public static TileStates[,] BattleBoard
        {
            get { return battleBoard; }
            set { battleBoard = value; }
        }

        public static TileStates[,] CreateBoard(TileStates[,] board)
        {
            for (int i = 1; i < 23; i++)
            {
                for (int j  = 1;  j < 11; j++)
                {
                    if (i == 11)
                    {
                        i++;
                        break;
                    }
                    board[i, j] = TileStates.WATER;
                }
            }
            return board;
        }
        
        public static void ChangeTile(int row, int col, TileStates tileType)
        {
            battleBoard[col, row] = tileType;
        }

        public static TileStates CheckBoard(TileStates[,] board, int row, int col)
        {
            if (board[col, row] == TileStates.WATER)
            {
                return TileStates.WATER;
            }
            else if (board[col, row] == TileStates.BOAT)
            {
                return TileStates.BOAT;
            }
            else if (board[col, row] == TileStates.MISS)
            {
                return TileStates.MISS;
            }
            else
            {
                return TileStates.HIT;
            }

        }
    }
}
