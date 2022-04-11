using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._06.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Third Number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Fourth Number");
            int num4 = int.Parse(Console.ReadLine());
            int av = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The Average of the four number is {0}", av);
            Console.ReadLine();
        }
    }
}
