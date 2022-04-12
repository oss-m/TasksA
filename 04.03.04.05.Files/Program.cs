using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03._04._05.Files
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
            using (StreamWriter txt1 = File.CreateText(path1))
            {
                txt1.WriteLine("Hello and Welcome\nNew Line");
                txt1.WriteLine("It is the first content");
                txt1.WriteLine("of the text file mytest.txt");
            }
            string s = "";
            int counter = 0;
            using (StreamReader txt2 = File.OpenText(path1))
            {
                while ((s = txt2.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    counter++;
                }
            }
            Console.WriteLine("Number of lines is {0}", counter);
        }
    }
}
