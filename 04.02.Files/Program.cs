using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02.Files
{
    internal class Program
    {
        static void Main()
        {
            var dir1 = "D:";
            var dir2 = @"D:\New folder";
           
            var file = "New Txt1.txt";
            
            var path1 = dir1 + @"\" + file;
            var path2 = dir2 + @"\" + file;
            
            Directory.CreateDirectory(dir2);
            if (File.Exists(path1))
            {
                File.Copy(path1, path2, true);
            }
        }
    }
}
