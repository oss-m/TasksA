using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._10.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Grade Charachter");
            char grade = char.Parse(Console.ReadLine());
            if (grade == 'E')
            {
                Console.WriteLine("Grade is Excellent");
            }
            else if (grade == 'V')
            {
                Console.WriteLine("Grade is Very Good");
            }
            else if (grade == 'G')
            {
                Console.WriteLine("Grade is Good");
            }
            else if (grade == 'A')
            {
                Console.WriteLine("Grade is Average");
            }
            else if (grade == 'F')
            {
                Console.WriteLine("Grade is Fail");
            }
            else
            {
                Console.WriteLine("The Value is not valid");
            }
            Console.ReadLine();
        }
    }
}
