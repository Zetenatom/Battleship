using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Models.Players
{
    public class Human : Player
    {
        private int humanScore { get; set; }
        public Human(string name,int score) : base(name)
        {
            humanScore = score;

        }
    }
}
