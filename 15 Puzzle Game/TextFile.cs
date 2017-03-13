using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15_Puzzle_Game
{
    class TextFile
    {
        public static void TextToGame(string path)
        {
            if (path != null)
            {
                string file = File.ReadAllText(path);
                string[] chars;
                chars = file.Split(new char[] { ' ', ',', '\t', '\n' });
                int[] tiles = new int[chars.Length];
                int n = 0;

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[n] =="")
                    {
                        throw new Exception("Ошибка: пустая строка");
                    }
                        tiles[i] = Convert.ToInt32(chars[n]);
                        n++;
                }

                Game puzzle = new Game(tiles);
            }

            else throw new NullReferenceException("Ошибка: ссылка на расположение файла отсутствует");
        }
    }
}
