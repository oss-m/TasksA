using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._05.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int mul = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, mul);
            }
            Console.ReadLine();
        }
    }
}