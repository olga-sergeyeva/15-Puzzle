using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Print
    {
        public static void ShowGameCondition(int[,] tiles)
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                    Console.Write(tiles[i, j]);
                Console.WriteLine();
            }
        }
    }
}
