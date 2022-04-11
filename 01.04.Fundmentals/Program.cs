using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04.Fundmentals
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter the candidate Age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("The candidate is eligible for casting his/her own vote");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for casting his/her own vote");
            }
            Console.ReadLine();
        }
    }
}
