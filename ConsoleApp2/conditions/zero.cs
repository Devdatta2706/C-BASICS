using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class zero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }

            else if (num < 0)
            {
                Console.WriteLine("Number is Negative");
            }

            else { Console.WriteLine("Number is Equal to zero");
            }

            }
        }
    }

