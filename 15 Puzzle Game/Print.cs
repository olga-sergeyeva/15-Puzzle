using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Print
    {
        public static void ShowGameCondition(Game puzzle)
        {
            for (int i = 0; i < puzzle.gameField.GetLength(0); i++)
            {
                for (int j = 0; j < puzzle.gameField.GetLength(1); j++)
                    Console.Write(puzzle.gameField[i, j]);
                Console.WriteLine();
            }
        }
    }
}
