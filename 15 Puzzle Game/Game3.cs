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

        public List<int> History;

        public override void Randomize()
        {
            base.Randomize();
            History.Clear();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            History.Add(value);
        }
    }
}
