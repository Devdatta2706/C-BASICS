using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.conditions
{
    internal class Ternary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER 1st Number");
                int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("ENter 2nd Number");
           int  num2= int.Parse(Console.ReadLine());

            int max= num1>num2 ? num2 : num1;
            Console.WriteLine(max);

            string ans = num1 > num2 ? "num1 is grtr" : "num2 is grtr";
            Console.WriteLine(ans);

        }
    }
}
