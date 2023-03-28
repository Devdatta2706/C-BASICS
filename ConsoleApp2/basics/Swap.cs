using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.basics
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIRST NUMBER");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER SECOND NUMBER");
            int n2= int.Parse(Console.ReadLine());

            int temp = n1;
            n1 = n2;
            n2 = temp;
            

        }
    }
}
