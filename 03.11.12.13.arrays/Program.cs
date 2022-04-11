using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._11._12._13.arrays
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter array no of rows");
            int row = 3;//int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter array no of columns");
            int col = 3;// int.Parse(Console.ReadLine());
            int[,] arr1 = new int[row, col];
            int[,] arr2 = new int[row, col];
            int counter = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr1[i, j] = counter;
                    arr2[i, j] = counter+6;
                    counter++;
                }
            }

            #region array1
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of input array 1 is {2}", i, j, arr1[i, j]);
                }
            }
            #endregion
            #region array2
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("volue of index ({0},{1}) of input array 2 is {2}", i, j, arr2[i, j]);
                }
            }
            Console.WriteLine();
            #endregion
            #region addition
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int sum = arr1[i, j] + arr2[i, j];
                    Console.WriteLine("volue of index ({0},{1}) of adding input arrays is is {2}", i, j, sum);
                }
            }
            Console.WriteLine();
            #endregion
            #region subtraction
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int sub = arr1[i, j] - arr2[i, j];
                    Console.WriteLine("volue of index ({0},{1}) of multiplication input arrays is is {2}", i, j, sub);
                }
            }
            Console.WriteLine();
            #endregion
            #region multiplication
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int mul = arr1[i, j] * arr2[i, j];
                    Console.WriteLine("volue of index ({0},{1}) of multiplication input arrays is is {2}", i, j, mul);
                }
            }
            #endregion
        }
    }
}
