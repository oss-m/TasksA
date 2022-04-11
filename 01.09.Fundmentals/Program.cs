using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._09.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the first angel");
            double ang1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the second angel");
            double ang2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the third angel");
            double ang3 = double.Parse(Console.ReadLine());

            double sm = ang1 + ang2 + ang3;

            if (sm == 180)
            {
                Console.WriteLine("The angels can form a triangel");
            }
            else
            {
                Console.WriteLine("The angels cannot form a triangel");
            }
            Console.ReadLine();
        }
    }
}
