using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.loop
{
    internal class evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER");
            int num=int.Parse(Console.ReadLine());

            switch (num % 2)
            {

                    case 0:
                    Console.WriteLine(num + "  IS EVEN NUMBER");
                    break;
                    case 1:Console.WriteLine(num + "  IS ODD NUMBER");
                    break;
            }
        }
    }
}
