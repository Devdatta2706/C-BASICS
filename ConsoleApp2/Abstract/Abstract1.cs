using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Abstract
{
    abstract class vehicle
    {
        public abstract void Vtype();
    }

    class car:vehicle
    {
        public override void Vtype()
        {
            Console.WriteLine("cars has 4 wheels");
        }
    }

    class bike:vehicle
    {
        public override void Vtype() 
        {
            Console.WriteLine("Bike has 2 wheels");
        
        }
    }


    internal class Abstract1
    {
        static void Main(string[] args)
        {
            vehicle v=new car();
            v.Vtype();
           
            

        }
    }
}
