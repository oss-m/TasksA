using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._08.arrays
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[6]{224,663,897,127,546,486};

            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
