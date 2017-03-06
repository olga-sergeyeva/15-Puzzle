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

        public string GetLocation(int value)
        {
            string coordinates = "";
            for (int i = 0; i < GameField.GetLength(0); i++)
            {
                for (int j = 0; j < GameField.GetLength(1); j++)
                {
                    if (value == GameField[i,j])
                    {
                        return coordinates = i.ToString() + j.ToString(); 
                    }
                }
            }
            return null;
        }

        public void Shift(int value)
        {
            int x = 0, y = 0;
            string coordinates = GetLocation(value);
            x = Convert.ToInt32(coordinates.Substring(0, 1));
            y = Convert.ToInt32(coordinates.Substring(1, 1));

            if (x - 1 != -1 & GameField[x - 1, y] == 0) //вверх
                MoveTile(GameField[x, y], GameField[x - 1, y]);

            if (x + 1!= GameField.GetLength(0) & GameField[x + 1, y] == 0) //вниз
                MoveTile(GameField[x, y], GameField[x + 1, y]);

            if (y + 1!= GameField.GetLength(0) & GameField[x, y + 1] == 0) //вправо
                MoveTile(GameField[x, y], GameField[x, y + 1]);

            if (y - 1 != -1 & GameField[x, y - 1] == 0) //влево
                MoveTile(GameField[x, y], GameField[x, y - 1]);
        }

        private void MoveTile(int a, int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
