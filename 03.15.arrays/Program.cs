using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._15.arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array side length");
            int side = 3;//int.Parse(Console.ReadLine());
            int[,] arr = new int[side, side];

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.WriteLine("Please enter index ({0},{1}) value", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of input array 1 is {2}", i, j, arr[i, j]);
                }
            }
            bool x = false;
            bool y = false;
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (i == j && arr[i, j] == 1)
                    {
                        x = true;
                    }
                    if (i != j && arr[i, j] == 0)
                    {
                        y = true;
                    }
                }
            }
            if (x == true && y == true)
            {
                Console.WriteLine("the matrix is an identity matrix");
            }
            else
            {
                Console.WriteLine("the matrix is not an identity matrix");
            }
        }
    }
}
