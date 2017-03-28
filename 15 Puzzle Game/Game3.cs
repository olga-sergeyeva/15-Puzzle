using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Game3 : Game2
    {
        private List<int> History;
        public List<int> history { get { return History; } }
        public Game3(int[] tiles) : base(tiles)
        {
            History = new List<int>();
        }

        public override void Randomize()
        {
            base.Randomize();
            if (History != null)
                History.Clear();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            History.Add(value);
        }

        public void Undo()
        {
            if (History.Count - 1 != - 1)
            {
                int LastTile = History[History.Count - 1];
                History.RemoveAt(History.Count - 1);
                Shift(LastTile);
            }
        }
    }
}
