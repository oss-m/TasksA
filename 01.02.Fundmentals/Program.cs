using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the first number");
            int frstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second number");
            int scndnum = int.Parse(Console.ReadLine());
            int sum = frstnum + scndnum;
            Console.WriteLine("The Sum of the two numbers = {0}", sum);
            Console.ReadLine();
        }
    }
}
