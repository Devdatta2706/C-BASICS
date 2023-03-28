using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");

            }
            else
            { 

                Console.WriteLine("Number is Odd");
            }
        }
    }
}
