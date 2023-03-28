using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Square
    {
        static void Main(string[] args)
        {
            int[] arr = {2,8,12,10};
            Console.WriteLine(string.Join("",arr));
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]<0)
                {
                    if(i<arr.Length-1)
                    {
                        arr[i] = arr[i - 1] * arr[i-1];
                    }
                    else if (arr[i]!=arr.Length-1)
                    {
                        arr[i] = arr[7] * arr[7];
                    }
                }
            }
            Console.WriteLine(string.Join(" , ",arr));
        }
    }
}
