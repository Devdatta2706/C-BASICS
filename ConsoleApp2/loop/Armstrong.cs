using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.loop
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER TO CHECK ARMSTRONG");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int r = 0;
            int sum = 0;

            while (num > 0)
            {
                r = num % 10;
                sum = sum+(r*r*r);
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
            

        }
    }
}
