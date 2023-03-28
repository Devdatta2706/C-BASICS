using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.loop
{
    internal class Count1
    {
        static void Main(string[] args)
        {
            int count1 = 1;
            for (int i = 20;i<= 50;i++)
            {
                if (i%2!= 0)
                {
                    count1++;
                }  
            }
            Console.WriteLine("Total count  " + count1);
        }
    }
}
