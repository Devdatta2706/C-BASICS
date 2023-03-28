using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.String
{
    internal class Equalsum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string containing only numbers: ");
            string input = Console.ReadLine();

            if (input.Length < 6)
            {
                Console.WriteLine("Invalid input. The string must contain at least 6 numbers.");
                return;
            }

            int firstSum = 0;
            int lastSum = 0;

            for (int i = 0; i < 3; i++)
            {
                firstSum += int.Parse(input[i].ToString());
                lastSum = int.Parse(input[input.Length - 3 + i].ToString());
            }

            if (firstSum == lastSum)
            {
                Console.WriteLine("Valid input.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

    }
}
