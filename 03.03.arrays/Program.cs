﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03.arrays
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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array index {0} is {1}", i, arr[i]);
            }
            int[] arr2 = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Copied array index {0} is {1}", i, arr2[i]);
            }
        }
    }
}
