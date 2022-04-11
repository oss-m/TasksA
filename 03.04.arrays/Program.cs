using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04.arrays
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
            double counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine("Number of duplicates is {0}", counter);
        }
    }
}
