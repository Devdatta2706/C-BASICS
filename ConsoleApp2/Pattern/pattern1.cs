using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pattern
{
    internal class pattern1
    {
        static void Main(string[] args)
        {
            for (int i=1; i <=4; i++) 
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            
            }
        }
    }
}
