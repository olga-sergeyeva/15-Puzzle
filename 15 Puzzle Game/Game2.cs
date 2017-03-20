using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Game2 : Game
    {
        public Game2(int[] tiles) : base(tiles) { Print.ShowGameCondition(GameField); }

        public void Randomize()
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

            Print.ShowGameCondition(GameField);
        }

    //    public bool CanBeFinished()
    //    {
    //        int CountDisorders = 0;
    //        int CurrentTile = 0;
    //        for (int i = 0; i < GameField.GetLength(0); i++)
    //        {
    //            CurrentTile = GameField[i, i * 1];
    //            for (int j = 0; j < GameField.GetLength(1); j++)
    //            {

    //            }
    //        }

    //        if (CountDisorders % 2 == 0)
    //            return true;
    //        else return false;
                
    //    }
    //}
}
