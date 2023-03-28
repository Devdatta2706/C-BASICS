using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.loop
{
    internal class avgdigit //code to calculate average of digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            int count1 = 0;

            while(num>0)
            {
                int digit = num % 10;
                total = total + digit;
                num= num / 10;
                count1++;
            }
            Console.WriteLine("Average = " + (total/count1)); 

        }
    }
}
