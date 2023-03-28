using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class Greater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());
        if (num1 > 50) 
            {
                Console.WriteLine("Number Is Greater than 50");

            }
        else if (num1<100)
            {
                Console.WriteLine("NUMBER is less thn 100");

            }
        else 
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
