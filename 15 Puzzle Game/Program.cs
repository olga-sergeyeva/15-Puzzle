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
            string path = "C:\\Users\\user\\Desktop\\1.txt";

            int[] tiles = new int[] { 1, 2, 4, 6, 7, 8, 5, 3, 0 };
            int[] NotRandomTiles = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0};
            Console.WriteLine("Пятнашки 0");
            Game puzzle0 = new Game(tiles);
            Console.WriteLine(puzzle0.GetLocation(2));
            Console.WriteLine();
            Print.ShowGameCondition(puzzle0);
            puzzle0.Shift(8);
            Print.ShowGameCondition(puzzle0);
            puzzle0.Shift(7);
            Print.ShowGameCondition(puzzle0);

            //Console.WriteLine("Пятнашки 1");
            //Game puzzle1 = new Game(TextFile.TextToGame(path));
            //Print.ShowGameCondition(puzzle1);
            //puzzle1.Shift(3);
            //Print.ShowGameCondition(puzzle1);

            Console.WriteLine("Пятнашки 2");
            Game3 puzzle2 = new Game3(tiles);
            Print.ShowGameCondition(puzzle2);
            Print.ShowGameCondition(puzzle2);
            puzzle2.Shift(8);
            Print.ShowGameCondition(puzzle2);
            puzzle2.Shift(7);
            Print.ShowGameCondition(puzzle2);
            foreach (int element in puzzle2.History)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Отменяем действие в пятнашках 2");
            puzzle2.Undo();
            Print.ShowGameCondition(puzzle2);
            foreach (int element in puzzle2.History)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Перемешиваем плитки в пятнашках 2");
            puzzle2.Randomize();
            Print.ShowGameCondition(puzzle2);
            foreach (int element in puzzle2.History)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
