using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._07.array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array length");
            int len = 6;//int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            int counter = 1;
            for (int i = 0; i < len; i++)
            {
                arr[i] = counter;
                counter++;
            }
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("volue of index {0} of input array is {1}", i, arr[i]);
            }
            Console.WriteLine();

            int counter2 = 0;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (arr[i]%2==0)
                {
                    counter++;
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("the array has {0} Even numbers & there sum is {1}",counter2,sum);
        }
    }
}
