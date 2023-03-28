using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array_test
{
    internal class Frequency
    {
        static void Main(string[] args)
        {
            char[] c= new char[7];
            Console.WriteLine("Enter" + (c.Length) + "element");
            for(int i=0;i<c.Length;i++)
            {
                c[i] = char.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i=0;i< c.Length;i++)
            {
                int count = 1;
                bool isvisited= false;
                
                for(int k=i-1;k>=0;k--)
                {
                    if (c[k] == c[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<c.Length;j++)
                    {
                        if (c[j] == c[i])
                        {
                            count++;
                        }
                    }

                    if(count==1)
                    {
                        Console.WriteLine(c[i]);
                    }
                }
            }
        }
    }
}
