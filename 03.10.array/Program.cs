using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10.array
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
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                }
            }
            Console.WriteLine("the second smallest element is {0}", arr[num-2]);
        }
    }
}
