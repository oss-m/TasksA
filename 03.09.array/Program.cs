using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._09.array
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter array length");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int counter = 1;
            for (int i = 0; i < num; i++)
            {
                arr[i] = counter;
                counter++;
            }
            Console.WriteLine("the array is");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("enter the index to be removed");
            int re = int.Parse(Console.ReadLine());
            int[] newarr = new int[num - 1];
            for (int i = 0; i < num-1; i++)
            {
                if (i >= re)
                {
                    newarr[i] = arr[i+1];
                }
                else
                {
                    newarr[i] = arr[i];
                }
            }
            Console.WriteLine("the new array is");
            for (int i = 0; i < num-1; i++)
            {
                Console.WriteLine(newarr[i]);
            }
        }
    }
}
