using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array_test
{
    internal class Evenodd
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 15, 17, 19, 20, 34, 36, 40 };
            Console.WriteLine("Input Array");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            int count1 = 0;
            int count2 = 0;
            for(int i=0;i< arr.Length;i++)
            {
                if (arr[i]%2==0)
                {
                    count1++;
                }
            }
            for(int i=0;i<=arr.Length;i++)
            {
                if (arr[i]%2==1)
                {
                    count2++;
                }
            }
            Console.WriteLine("No of even element in array" + count1);
            Console.WriteLine("No of odd element in array" + count2);
        }
    }
}
