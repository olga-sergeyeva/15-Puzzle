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
            if (Math.Sqrt(tiles.Length) - Math.Truncate(Math.Sqrt(tiles.Length)) == 0)
            {
                int n = 0;
                int side = (int)Math.Sqrt(tiles.Length);
                GameField = new int[side, side];

                for (int i = 0; i < side; i++)
                    for (int j = 0; j < side; j++)
                    {
                        GameField[i, j] = tiles[n];
                        n++;
                    }
            }

            else throw new Exception("Ошибка: из заданных элементов невозможно сформировать квадратное поле");
        }

        private int this[int x, int y]
        {
            get { return GameField[x, y]; }
        }

        public Tuple<int, int> GetLocation(int value)
        {
            for (int i = 0; i < GameField.GetLength(0); i++)
                for (int j = 0; j < GameField.GetLength(1); j++)
                    if (GameField[i, j] == value)
                        return new Tuple<int, int>(i, j);

            throw new Exception("Ошибка: значение отсутсвует");
        }

        public void Shift(int value)
        {
            int x = GetLocation(value).Item1;
            int y = GetLocation(value).Item2;

            if (x - 1 != -1 & GameField[x - 1, y] == 0) //вверх
                MoveTile(GameField[x, y], GameField[x - 1, y]);

            if (x + 1 != GameField.GetLength(0) & GameField[x + 1, y] == 0) //вниз
                MoveTile(GameField[x, y], GameField[x + 1, y]);

            if (y + 1 != GameField.GetLength(0) & GameField[x, y + 1] == 0) //вправо
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
