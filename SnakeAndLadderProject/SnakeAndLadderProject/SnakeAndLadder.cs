using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProject
{
    internal class SnakeAndLadder
    {
        public void playerRolledDie()
        {
            Console.WriteLine("Snake And Ladder");
            Random random = new Random();
            int player = random.Next(0, 6) + 1;
            Console.WriteLine("Outcome is : " + player);
        }

    }
}
