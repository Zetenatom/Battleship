using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Models.Players
{
    public class AI : Player
    {
        public AI(string name) : base(name)
        {

        }

        public static void aiAttack()
        {
            Random rand = new Random();
            
            Controller.Controller.FireCannons(rand.Next(1, 11), rand.Next(1, 11));
        }
    }
}
