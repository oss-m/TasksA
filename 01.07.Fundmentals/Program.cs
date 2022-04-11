using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number");
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double div = num1 / num2;
            Console.WriteLine("summation = {0}", sum);
            Console.WriteLine("subtraction = {0}", sub);
            Console.WriteLine("multblication = {0}", mul);
            Console.WriteLine("division = {0}", div);
            Console.ReadLine();
        }
    }
}
