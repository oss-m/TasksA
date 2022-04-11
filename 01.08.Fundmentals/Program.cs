using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._08.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter 10 numbers");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());
            double num6 = double.Parse(Console.ReadLine());
            double num7 = double.Parse(Console.ReadLine());
            double num8 = double.Parse(Console.ReadLine());
            double num9 = double.Parse(Console.ReadLine());
            double num10 = double.Parse(Console.ReadLine());

            double av = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10) / 10;
            double sm = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10);
            Console.WriteLine("summation = {0}", sm);
            Console.WriteLine("average = {0}", av);

            Console.ReadLine();
        }
    }
