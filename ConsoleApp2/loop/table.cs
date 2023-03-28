using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.loop
{
    internal class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER FOR TABLE");
            int num=int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++) 
            {
              Console.WriteLine(num*i);
            }
        }
    }
}
