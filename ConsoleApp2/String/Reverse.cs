using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Reverse// reverse without temp
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, };
            Console.WriteLine(string.Join(" ", a));
            int end=a.Length-1;

            for(int start = 0; start < a.Length; start++)
            {
                while(end > start) 
                {
                    a[start] = a[end];
                    a[end] = a[start];
                    a[start] = a[end];
                    start++;
                    end--;
                }
            }
            Console.WriteLine(string.Join(",",a));
        }
    }
}
