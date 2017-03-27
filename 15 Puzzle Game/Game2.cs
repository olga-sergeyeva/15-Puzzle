using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Game2 : Game
    {
        public Game2(int[] tiles) : base(tiles) { }

        public virtual void Randomize()
        {
            Random Generator = new Random();
            for (int i = GameField.Length ; i >= 0; i--)
            {
                int x1 = Generator.Next(GameField.GetLength(0));
                int x2 = Generator.Next(GameField.GetLength(1));
                int y1 = Generator.Next(GameField.GetLength(0));
                int y2 = Generator.Next(GameField.GetLength(1));

                MoveTile(ref GameField[x1, y1], ref GameField[x2, y2]);
            }
        }

        public override void Shift(int value)
        {
            base.Shift(value);
        }

        public bool IsFinished()
        {
            int[] RightOrderofTiles = new int[GameField.Length];
            for (int i = 0; i < RightOrderofTiles.Length; i++)
                    RightOrderofTiles[i] = i;

            int count = 0;
            for (int i = 0; i < GameField.GetLength(0); i++)
            {
                for (int j = 0; j < GameField.GetLength(1); j++)
                {
                    if (GameField[i, j] != RightOrderofTiles[count])
                        return false;

                    count++;
                }
            }
            return true;
        }
    }
}
