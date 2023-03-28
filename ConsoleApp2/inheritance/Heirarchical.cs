using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.inheritance
{

    class Games
    {
        public string game = "outdoor games";
    }

    class football:Games
    {
        protected string b = "Refree";


        public void Showfoot()
        {
            Console.WriteLine("Football is " + game + " contain " + b);
        }
    }


    class cricket:Games
    {
        protected string a = "umpire";


        public void Showcric()
        {
            Console.WriteLine("cricket is " + game + " contain " + a);
        
        }
    }
    internal class Heirarchical
    {
         static void Main(string[] args)
        {
            cricket c= new cricket();
            c.Showcric();

            football f= new football();
            f.Showfoot();
        }
    }
}
