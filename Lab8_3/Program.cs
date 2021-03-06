using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbol = 0;
            int line = 0;
            long word = 0;
            string path = "Text.txt";
            string text;
            string[] words;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(path))
            {
                while ((sr.ReadLine()) != null)
                {
                    line++;
                }
            }
            symbol = text.Length - (2 * (line - 1));
            //symbol = text.Length; //- На случай, если нужно было считать символы перехода на новую строку
            words = text.Split('\n', ' ');
            foreach (string s in words)
            {
                word++;
            }
            Console.WriteLine("Количество символов в файле: {0};", symbol);
            Console.WriteLine("Количество слов в файле: {0};", word);
            Console.WriteLine("Количество строк в файле: {0};", line);
            Console.ReadKey();
        }
    }
}
