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
            string file = File.ReadAllText(path);
            GameFile.TextToGame(file);
            Console.ReadLine();
        }
    }
}
