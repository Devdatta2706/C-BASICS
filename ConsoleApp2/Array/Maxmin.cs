using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class Maxmin
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2, 3, 4, 5};
            int max = arr[0];
            int min = arr[0];

            for(int i=1;i<arr.Length;i++) 
            {
                if (arr[i]>max) 
                {
                  max= arr[i];
                }
                if (arr[i]<min) 
                {
                  min= arr[i];
                }
            }
            Console.WriteLine("Max element is: "+max);
            Console.WriteLine("Min element is: " + min);
        }
    }
}
