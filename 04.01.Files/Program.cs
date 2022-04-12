using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01.Files
{
    internal class Program
    {
        static void Main()
        {
            var path1 = @"D:\New Txt1.txt";
            if (File.Exists(path1))
            {
                File.Delete(path1);
            }
            else
            {
                File.Create(path1);
            }
        }
    }
}
