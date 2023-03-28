using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Pattern
{
    internal class patternB
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'D'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            

            }
        }
    }
}
