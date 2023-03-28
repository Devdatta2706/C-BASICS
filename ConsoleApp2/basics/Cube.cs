using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.basics
{
    internal class Cube

    {
        static void Main(string[] args)
        {
            int num =int.Parse(Console.ReadLine());
            int result = num * num * num;
            Console.WriteLine("cube= "+result);
         
        }
    }
}
