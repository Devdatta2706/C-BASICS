using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class Positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            }
        }

    }

