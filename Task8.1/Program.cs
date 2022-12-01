using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\ES";
            string pattern = ".";
            string[] files = Directory.GetDirectories(path, pattern, SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
                Console.ReadKey();
        } 
    }
}
