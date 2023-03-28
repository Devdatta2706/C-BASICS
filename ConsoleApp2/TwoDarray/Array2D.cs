using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TwoDarray
{
    internal class Array2D
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            int[] sumArray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                sumArray[i] = array1[i] + array2[i];
            }

            
            foreach (int num in sumArray)
            {
                Console.WriteLine("sum of array is " + num);
            } 

        }
    }
}
