using ConsoleApp2.loop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class Arraysum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
            int sum = 0;

            foreach(int num in arr) 
            {
             sum+= num;
            }
            Console.WriteLine(sum);
        }
    }
}
