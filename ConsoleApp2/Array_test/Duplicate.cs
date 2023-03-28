using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array_test
{
    internal class Duplicate
    {
        static void Main(string[] args)
        {
            int[] arr= new int[7];
            int[] b= new int[7];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int sum=0;
            for(int i=0;i< arr.Length;i++)
            {
                int count = 1;
                bool isvisited= false;

                for(int k=i-1;k>=0;k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        if (arr[j] == arr[i])
                        {
                            count++;
                        }
                    }

                    if(count==1)
                    {
                        b[i] = arr[i];
                    }

                }
                Console.WriteLine(b[i]);
            }
        }
    }
}
