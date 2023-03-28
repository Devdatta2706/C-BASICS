using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Abstract
{
    internal  abstract class Operate1
    {
        public int a;
    }

    internal interface INumable
    {
        static int b;
    }

    internal class solution : Subtraction, INumable
    {
        internal int a;

        public void Display(int sol)
        {
            Console.WriteLine("subtraction = "+sol);
        }
        

    }

    internal class operation
    {
        static void Main(string[] args)
        {
            solution sol=new solution();
            Console.WriteLine("Enter vale of a");
            sol.a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            INumable.b=int.Parse(Console.ReadLine());
            int c=sol.a-INumable.b;
            sol.Display(c);
        }
    }
}
