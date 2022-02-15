using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProject
{
    internal class Program
    {
        const int POSITION = 0;
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to Snake and Ladder Simulator program \n");
            SnakeAndLadder player = new SnakeAndLadder();
            player.StartPosition();
            Console.ReadLine();
        }
    }
}
