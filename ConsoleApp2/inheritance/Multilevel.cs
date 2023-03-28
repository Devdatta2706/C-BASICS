using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.inheritance
{
    class Animal
    {
        protected string All = "Contain every animal";
    }

    class Aquatic:Animal
    {
        protected string aqua = "conatins creature living in water";  
    }


    class Fish:Aquatic
    {
         string riv = "contains creature living in rivers";

        public void Show()
        { 
            Console.WriteLine(All+ " " + aqua + " " +" "+riv);
        
        }
    }

    internal class Multilevel
    {
        static void Main(string[] args)
        {
            Fish a= new Fish();
            a.Show();
            
        
        }
    }
}
