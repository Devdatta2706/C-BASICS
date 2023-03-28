using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.basics
{
    internal class Avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FIRST NUMBER");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER SECOND NUMBER");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER THIRD NUMBER");
            int num3 = int.Parse(Console.ReadLine());

            int average= num1+ num2+ num3;
            Console.WriteLine("Average= " + average/3);
        }
    }
}
