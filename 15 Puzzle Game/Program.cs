using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] Tiles = new int[] { 3, 1, 5, 2, 6, 7, 8, 4, 0 };
            Game puzzle = new Game(Tiles);

            Console.ReadLine();
        }
    }
}
