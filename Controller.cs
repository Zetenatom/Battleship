using Battleship.Models;
using Battleship.Models.Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Controller
{
    public class Controller
    {
        private static bool playerWon;
        private static bool playerTurn;
        private static int score;
        private static Player player;
        private static Player player2;
        private static Ship[] ships;
        public static int row1;
        public static int column1;

        public static bool SwitchTurn()
        {
            int player = 1;
            if (player == 1)
            {
                CheckForHumanWin(Models.Board.Board.BattleBoard);
                player = 2;
            }
            else
            {
                AI.aiAttack();
                CheckForAIWin(Models.Board.Board.BattleBoard);
                player = 1;
            }
            return true;
        }

        public static bool CheckForAIWin(Enum.TileStates[,] board)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (board[i, j].Equals(Enum.TileStates.BOAT))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool CheckForHumanWin(Enum.TileStates[,] board)
        {
            for (int i = 12; i < 23; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (board[i,j].Equals(Enum.TileStates.BOAT))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static Enum.TileStates FireCannons(int column, int row)
        {
            Enum.TileStates tileT = Models.Board.Board.CheckBoard(Models.Board.Board.BattleBoard, row, column);

            if (tileT == Enum.TileStates.BOAT)
            {
                Models.Board.Board.ChangeTile(row, column, Enum.TileStates.HIT);
                tileT = Enum.TileStates.HIT;
            }
            else if (tileT == Enum.TileStates.WATER)
            {
                Models.Board.Board.ChangeTile(row, column, Enum.TileStates.MISS);
                tileT = Enum.TileStates.MISS;
            }
            else if (tileT == Enum.TileStates.MISS)
            {
                Models.Board.Board.ChangeTile(row, column, Enum.TileStates.MISS);
                tileT = Enum.TileStates.MISS;
            }
            else if (tileT == Enum.TileStates.MISS)
            {
                Models.Board.Board.ChangeTile(row, column, Enum.TileStates.HIT);
                tileT = Enum.TileStates.HIT;
            }
            return tileT;
        }

        public static void SaveScores(int currentScore)
        {
            string saveFile = "";
            File.AppendAllText(saveFile, $"{Environment.NewLine}");
        }

        public static void LoadScores()
        {
            string[] scores = new string[5];


        }

        public static void Run()
        {

        }
    }
}
