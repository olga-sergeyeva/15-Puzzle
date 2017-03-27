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
            for (int i = 0; i < puzzle.GameField.GetLength(0); i++)
            {
                for (int j = 0; j < puzzle.GameField.GetLength(1); j++)
                    Console.Write(puzzle.GameField[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
