using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.loop
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER TO CHECK PALIMDROME");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int r = 0;
            int sum = 0;

            while(num > 0) 
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num/10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }


        }
    }
}
