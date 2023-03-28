using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class Multiple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 3 == 0) 
            {
                Console.WriteLine("Number is Multiple of 3");
            }
            else 
            {
                Console.WriteLine("Number is not a Multiple of 3");
            }
        }
    }
}
