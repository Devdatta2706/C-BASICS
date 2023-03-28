using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array_test
{
    internal class Reverse
    {
        static int m = 2;
        static int n = 3;

        static void Main(string[] args)
        {
            for(int i=0;i<m; i++)
            {
                int start = 0;
                int end = n - 1;
                while(start < end)
                {
                   // int temp = arr[i, start];
                   // arr[i, start] = arr[i, start];
                   // arr[i, end] = temp;
                    start++;
                    end--;
                    
                }

            }
            for(int i=0;i<=m; i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
