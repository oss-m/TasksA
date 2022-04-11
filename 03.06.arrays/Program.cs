using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._06.arrays
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter array no of rows");
            int row = 3;//int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter array no of columns");
            int col = 3;// int.Parse(Console.ReadLine());
            int[,] arr = new int[row,col];
            int counter = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i,j] = counter;
                    counter++;
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of input array is {2}", i, j, arr[i, j]);
                }
            }
            int[,] ev_arr = new int[row, col];
            int[,] odd_arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        ev_arr[i, j] = arr[i, j];
                        odd_arr[i, j] = 0;
                    }
                    else
                    {
                        odd_arr[i, j] = arr[i, j];
                        ev_arr[i, j] = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of even array is {2}", i, j, ev_arr[i, j]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of even array is {2}", i, j, odd_arr[i, j]);
                }
            }
        }
    }
}
