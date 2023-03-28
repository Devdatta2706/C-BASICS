using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class Mergearray
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            int[] mergedArray = array1.Concat(array2).ToArray();

            
            foreach (int num in mergedArray)
            {
                Console.WriteLine(num +" ");
            }

        }
    }
}
