using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Program Files (x86)";
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            string[] dirfiles;
            string[] dirdirs;
            foreach (string d in dirs)
            {
                Console.WriteLine(d);
                dirdirs = Directory.GetDirectories(d);
                dirfiles = Directory.GetFiles(d);
                foreach (string dd in dirdirs)
                {
                    Console.WriteLine(dd);
                }
                foreach (string df in dirfiles)
                {
                    Console.WriteLine(df);
                }
                
            }
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
