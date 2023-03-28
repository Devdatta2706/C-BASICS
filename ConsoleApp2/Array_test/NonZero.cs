using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array_test
{
    internal class NonZero
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 0, 5, 9, 0, 6, 0, 3, 0 };
            int n=a.Length;
            int j = 0;
            for(int i=0; i<n; i++)
            {
                if (a[i]!= 0)
                {
                    int temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;    
                    j++;

                }
            }
            for( int i=0;i<n; i++)
            {
                Console.WriteLine(a[i]);
                Console.WriteLine(" ");
            }
        }
    }
}
