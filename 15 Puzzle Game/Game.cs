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
            int n = 0;
            int width = (int)Math.Sqrt(tiles.Length);
            int length = width;
            GameField = new int[width, length];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    GameField[i, j] = tiles[n];
                    n++;
                }
            }
            return GameField;
        }

        public int this[int x, int y]
        {
            get { return GameField[x, y]; }
            set { GameField[x, y] = value; }
        }

        public void GetLocation(int value)
        {
            for (int i = 0; i < GameField.GetLength(0); i++)
            {
                for (int j = 0; j < GameField.GetLength(1); j++)
                {
                    if (value == GameField[i,j])
                    {
                        Console.WriteLine("Элемент {0} находится в ячейке [{1}, {2}]", value, i, j);
                    }
                }
            }
        }
    }
}
