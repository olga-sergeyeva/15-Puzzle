using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Game
    {
        private int[,] GameField;

        public Game(int[] tiles)
        {
            GameField = FormGameField(tiles);
        }

        private int[,] FormGameField(int[] tiles)
        {
                int width = (int)Math.Sqrt(tiles.Length);
                int length = width;

                for (int i = 0; i < width; i++)
                    for (int j = 0; j < length; j++)
                        GameField[i, j] = tiles[i];

                return GameField;
        }
    }
}
