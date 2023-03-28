using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Sorting
    {
        public static void SortArray(int[]a)
        {
            Console.WriteLine(string.Join(", ",a));
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, };
            Sorting.SortArray(a);
            Console.WriteLine(string.Join(",",a));

        }
    }
}
