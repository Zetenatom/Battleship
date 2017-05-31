using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Models.Players
{
    public abstract class Player
    {
        private string name;
        private int numOfShips;
        private Ship[] ships;
        public int NumOfShipsLeft { get; set; }

        public Player(string name)
        {

        }


    }
}
