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
            Console.WriteLine("welcome to snake ladder problem");
            SnakeAndLadder snake = new SnakeAndLadder();
            snake.playGame();


            Console.ReadLine();
        }
    }
}
