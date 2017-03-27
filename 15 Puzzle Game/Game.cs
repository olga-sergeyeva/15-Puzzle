using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Game
    {
        protected int[,] gameField;

        public int[,] GameField { get { return gameField; } }

        public Game(int[] tiles)
        {
            Check(tiles);
            if (Math.Sqrt(tiles.Length) - Math.Truncate(Math.Sqrt(tiles.Length)) == 0)
            {
                int side = (int)Math.Sqrt(tiles.Length);
                gameField = new int[side, side];
                FillGameField(tiles, side); 
            }
            else throw new Exception("Ошибка: из заданных элементов невозможно сформировать квадратное поле");
        }

        private void FillGameField(int[] tiles, int side)
        {
            int n = 0;
            for (int i = 0; i < side; i++)
                for (int j = 0; j < side; j++)
                {
                    gameField[i, j] = tiles[n];
                    n++;
                }
        }

        public void Check(int[] tiles)
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
                if (i + 1!= tiles.Length && tiles[i] == tiles[i + 1])
                    throw new Exception("Ошибка: На поле имеются повторяющиеся ячейки");
            }

            for (int i = 0; i < tiles.Length; i++)
            {
                if (!tiles.Contains(i))
                    throw new Exception("Ошибка: Поле заполнено неверными элементами");
            }
        }

        public int this[int x, int y]
        {
            get { return gameField[x, y]; }
        }

        public Tuple<int, int> GetLocation(int value)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
                for (int j = 0; j < gameField.GetLength(1); j++)
                    if (gameField[i, j] == value)
                        return new Tuple<int, int>(i, j);

            throw new Exception("Ошибка: указанное значение отсутсвует");
        }

        public virtual void Shift(int value)
        {
            int x0 = GetLocation(0).Item1;
            int y0 = GetLocation(0).Item2;

            int xv = GetLocation(value).Item1;
            int yv = GetLocation(value).Item2;

            if (((xv - 1 == x0 || xv + 1 == x0) && yv == y0) || ((yv - 1 == y0 || yv + 1 == y0) && xv == x0))
            {
                MoveTile(ref gameField[x0, y0], ref gameField[xv, yv]);
            }

            else throw new Exception("Ошибка: Рядом нет пустой ячейки");

        }

        protected void MoveTile(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
