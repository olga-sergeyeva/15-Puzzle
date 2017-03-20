using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Game3 : Game2
    {
        public Game3(int[] tiles) : base(tiles) { }

        List<int> History;

        public override void Shift(int value)
        {
            int x0 = GetLocation(0).Item1;
            int y0 = GetLocation(0).Item2;

            int xv = GetLocation(value).Item1;
            int yv = GetLocation(value).Item2;

            if (((xv - 1 == x0 || xv + 1 == x0) && yv == y0) || ((yv - 1 == y0 || yv + 1 == y0) && xv == x0))
            {
                MoveTile(ref GameField[x0, y0], ref GameField[xv, yv]);
                History.Add(value);
            }

            else throw new Exception("Ошибка: Рядом нет пустой ячейки");
        }
    }
}
