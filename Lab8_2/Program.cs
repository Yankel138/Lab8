using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string s;
            string path = "Test.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-100,100));
                }
            }
            
            using (StreamReader sr = new StreamReader(path))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    sum += Convert.ToInt32(s);
                }
                Console.WriteLine("Сумма чисел в файле: {0}", sum);

            }
            Console.ReadKey();
        }
    }
}
