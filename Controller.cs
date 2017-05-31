using Battleship.Models;
using Battleship.Models.Players;
using System;
using System.Collections.Generic;
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


        public static bool SwitchTurn()
        {

            return true;
        }

        public static bool CheckForWin()
        {
            return true;
        }

        public static bool FireCannons(int column, int row)
        {
            return true;
        }

        public static void SaveScores()
        {

        }

        public static void LoadScores()
        {

        }

        public static void Run()
        {

        }
    }
}
