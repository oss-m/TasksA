using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._14.arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array side length");
            int side = 3;//int.Parse(Console.ReadLine());
            int[,] arr = new int[side, side];
            int counter = 1;
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    arr[i, j] = counter;
                    counter++;
                }
            }
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of input array 1 is {2}", i, j, arr[i, j]);
                }
            }
            int sum = 0;
            for (int i = 0; i < side; i++)
            {
                int col = side - 1 - i;
                int row = i;
                sum = sum + arr[col, row];
            }
            Console.WriteLine("sum of right diagonal is {0}", sum);
        }
    }
}
