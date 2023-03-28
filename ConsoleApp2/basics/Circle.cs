using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.basics
{
    internal class Circle
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());   ;
            int result = (int)(3.14 * a * a);
            Console.WriteLine("Area of Circle= " + result);
        }
    }
}
