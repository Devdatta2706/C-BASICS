using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Replace
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 3, 4, 5, 0, 6, 7, 8, 0 };
            Console.WriteLine(string.Join(" ", arr));
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if (arr[i]==0)
                    {
                        arr[i] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(",",arr));
        }
    }
}
