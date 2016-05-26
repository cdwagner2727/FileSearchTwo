using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSearchTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder finder = new Finder();
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            Console.WriteLine(finder.Find(dir, "Butt.txt"));
            Console.WriteLine(finder.getCount());
            Console.ReadLine();
        }
    }
}
