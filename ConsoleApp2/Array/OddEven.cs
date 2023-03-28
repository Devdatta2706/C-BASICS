using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            int[]arr = {1,2, 3,4,5,6,7,8,9,10};
            int[] evenarr=new int[arr.Length];
            int[] oddarr=new int[arr.Length];

            int even=0, odd=0;

            for (int i=0; i < arr.Length;i++)
            {
                if (arr[i]%2==0)
                {
                    evenarr[even]= arr[i];
                    even++;
                }
                else
                {
                    oddarr[odd]= arr[i];
                    odd++;
                }
            }
            for(int i=0;i<even;i++)
            {
                Console.WriteLine("Even elements are:" + evenarr[i]);
            }

            for(int i=0;i<odd;i++)
            {
                Console.WriteLine("Odd elements are:" + oddarr[i]);
            }
        }
    }
}
