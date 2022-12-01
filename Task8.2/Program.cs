using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\ES\Test.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i=0; i<10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            int S = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                   S+=Convert.ToInt32(sr.ReadLine());
                    
                }
                Console.WriteLine(S);
                Console.ReadKey();

            }
        }
    }
}
