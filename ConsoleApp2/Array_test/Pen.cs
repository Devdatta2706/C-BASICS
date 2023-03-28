using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Array_test
{
    class Pen
    {
        string refill;
        int caplength;
        string brand;
        string materialtype;
        int width;
        string inkcolour;
        int length;
        string nib;

        public string Refill
        {
            set { refill = value; }
            get { return refill; }  
        }
        public int Caplength
        {
            get { return caplength; }
            set { caplength = value; }  
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Ikcolour
        {
            get { return inkcolour; }
            set { inkcolour = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; } 
        }
        public string Nib
        {
            get { return nib; }
            set { nib = value; }
        }

        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }

        }
        public int Width
        {
            get { return width; }
            set
            {
                width = value;
            }

           
        }
        static void Main(string[] args)
        {
            Pen p=new Pen();
            p.refill = "Ball Point Refill";
            p.Caplength = 3;
            p.brand = "Cello";
            p.materialtype = "Plastic";
            p.width = 4;
            p.inkcolour = "red";
            p.nib = "Ballpoint";
            p.length = 5;
            Console.WriteLine( p.refill );
            Console.WriteLine( p.caplength );
            Console.WriteLine( p.brand );
            Console.WriteLine( p.materialtype );
            Console.WriteLine( p.width );
            Console.WriteLine(p.inkcolour);
            Console.WriteLine( p.nib );
            Console.WriteLine( p.length );
        }
    }
}
