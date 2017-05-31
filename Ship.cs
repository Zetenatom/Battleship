using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Models
{
    public abstract class Ship
    {
        public readonly int shipSize;
        public readonly string shipName;
        private int hits { get; }

        public Ship(string name, int size)
        {

        }

        public void HitShip()
        {

        }
    }
}
