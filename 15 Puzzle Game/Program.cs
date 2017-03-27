using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15_Puzzle_Game
{
    class Program
    {
        static void Main(string[] args)
        {
//            три примера, первый просто подвигать
//второй считать из файла и довести до выйгрыша
//и третий с историей поиграться
            string path = "C:\\Users\\user\\Desktop\\1.txt";

            Game puzzle1 = new Game(TextFile.TextToGame(path));
            Print.ShowGameCondition(puzzle1);
            //int[] tiles = new int[9]{ 1, 5, 6, 4, 0, 2, 7, 8, 3 };
            //Game2 puzzle = new Game2(tiles);
            //puzzle.Randomize();
            //puzzle.Shift(1);
            //puzzle.GetLocation(8);
            Console.ReadLine();
        }
    }
}
