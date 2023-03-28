using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class SortArray
    {
        static void Main(string[] args)
        {
            int[] arr = {3,4,5, 0, 2, 1 };
            int size = arr.Length;
            int half = size / 2;


            for (int i = 0; i < half - 1; i++) //descending
            {
                for (int j = i+1; j < half; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            for (int i = half; i < size - 1; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();



        }
    }
            

           
}

