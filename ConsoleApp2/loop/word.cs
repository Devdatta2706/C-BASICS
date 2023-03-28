using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.NewFolder
{
    internal class word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 5");
         
            char op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '1':
                    Console.WriteLine("One");
                    break;
                case '2':
                    Console.WriteLine("Two");
                    break;
                case '3':
                    Console.WriteLine("Three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("Five");
                    break;

            }
        }
    }
}
