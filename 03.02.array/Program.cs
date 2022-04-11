using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02.array
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter array length");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please Enter Value of index {0}", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                counter = counter + arr[i];
            }
            Console.WriteLine("Sum of the array is {0}", counter);
        }
    }
}
