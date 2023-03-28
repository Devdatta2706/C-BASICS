using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class nested
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIRST NUMBER");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER  SECOND NUMBER");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THIRD NUMBER");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {

                if (num1 > num3)

                {
                    Console.WriteLine("NUM 1 IS GREATER");


                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("NUM 2 IS GREATER");

            }
            else
            {
                Console.WriteLine("NUM 3 IS GREATER");

            }
            }
        }
    }
