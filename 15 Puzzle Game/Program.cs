using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Puzzle_Game
{
    class Program
    {
        static bool CheckTiles(int[] Tiles)
        {
            if (Math.Sqrt(Tiles.Length) - Math.Truncate(Math.Sqrt(Tiles.Length)) == 0)
                return true;
            else return false;
        }

        static void Main(string[] args)
        {
            int[] Tiles = new int[] {3,1,5,2,6,7,8,4,0};

            if (CheckTiles(Tiles) == true)
            {
                Game puzzle = new Game(Tiles);
            }

            else Console.WriteLine("Из заданного массива невозможно сформировать квадратное поле");
            Console.ReadLine();
        }
    }
}
