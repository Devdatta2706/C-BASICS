using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.basics
{
    internal class Percent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER MARKS OF ENGLISH");
            int English = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER MARKS OF MATHS");
            int Maths = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER MARKS OF SCIENCE");
            int Science = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER MARKS OF HISTORY");
            int History = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER MARKS OF MARATHI");
            int Marathi = int.Parse(Console.ReadLine());

            int total = English+ Maths+ Science+ History+ Marathi;
            Console.WriteLine("TOTAL MARKS= "+ total);

            float Percentage = (float)(total / 500.0 * 100);
            Console.WriteLine("PERCENTAGE = " + Percentage+ "%");
             
            Console.WriteLine("===============================");




        }
    }
}
