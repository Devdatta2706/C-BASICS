using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class Multiple2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 3==0 && num1 % 9 == 0) 
                    
            {
                Console.WriteLine("Number is Divisible by 3 and 9 ");
            }
            else if (num1 % 9 == 0) 
            {
                Console.WriteLine("NUmber is divisible by 9 but not by 3");

            }
            else 
            {
                Console.WriteLine("Not Divisible by 3 and 9");
            }
        }
    }
}
