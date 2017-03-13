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
            Check(tiles);
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

                Print.ShowGameCondition(GameField);
            }

            else throw new Exception("Ошибка: из заданных элементов невозможно сформировать квадратное поле");
        }

        private void Check(int[] tiles)
        {
            if (tiles.Length == 0)
            {
                throw new Exception("Ошибка: На поле отсутсвуют ячейки");
            }

            if (tiles.Length == 1)
            {
                throw new Exception("Ошибка: На поле всего одна ячейка");
            }

            for (int i = 0; i < tiles.Length; i++)
            {
                if (tiles[i] < 0)
                    throw new Exception("Ошибка: На поле имеется отрицательный элемент");
            }

            for (int i = 0; i < tiles.Length; i++)
            {
                if (tiles[i] == tiles.Length || tiles[i] > tiles.Length)
                    throw new Exception("Ошибка: На поле имеются элементы, значения которых больше или равны длине стороны");
            }

            //for (int i = 0; i < tiles.Length; i++)
            //{
            //    if (tiles[i + 1] != tiles.Length && tiles[i] == tiles[i + 1])
            //        throw new Exception("Ошибка: На поле имеются повторяющиеся ячейки");
            //}

            for (int i = 0; i < tiles.Length; i++)
            {
                if (!tiles.Contains(i))
                    throw new Exception("Ошибка: Поле заполнено неверными элементами");
            }
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
            int x0 = GetLocation(0).Item1;
            int y0 = GetLocation(0).Item2;

            int xv = GetLocation(value).Item1;
            int yv = GetLocation(value).Item2;

            if (((xv - 1 == x0 || xv + 1 == x0) && yv == y0) || ((yv - 1 == y0 || yv + 1 == y0) && xv == x0))
            {
                MoveTile(ref GameField[x0, y0], ref GameField[xv, yv]);
                Print.ShowGameCondition(GameField);
            }

            else throw new Exception("Ошибка: Рядом нет пустой ячейки");

        }

        private void MoveTile(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
