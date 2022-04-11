using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the first number");
            int frstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second number");
            int scndnum = int.Parse(Console.ReadLine());
            int temp = frstnum;
            frstnum = scndnum;
            scndnum = temp;
            Console.WriteLine("The first number is {0}\nThe second number is {1}", frstnum, scndnum);
            Console.ReadLine();
        }
    }
}
