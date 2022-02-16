using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProject
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to Snake and Ladder Simulator program \n");
            SnakeAndLadder player = new SnakeAndLadder();
            player.PlaySnakeAndLadder();
            
            Console.ReadLine();

        }
    }
}
