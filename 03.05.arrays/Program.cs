using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05.arrays
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

            Console.WriteLine("Unique array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool x = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        x = true;
                        break;
                    }
                }
                if (x == false)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
